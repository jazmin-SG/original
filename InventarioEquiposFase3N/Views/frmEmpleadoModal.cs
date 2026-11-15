using InventarioEquiposFase3N.Controllers;
using InventarioEquiposFase3N.Models;
using InventarioEquiposFase3N.Services;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InventarioEquiposFase3N
{
    public partial class frmEmpleadoModal : Form
    {
        public Empleado EmpleadoActual { get; }
        private readonly EmpleadoController _controller;
        private readonly DepartamentosController _departamentosController;
        private readonly ServicioFotoEmpleado _fotos;
        private readonly Image _imagenSinFoto;
        private Image? _imagenTemporal;
        public string? ArchivoFotoSeleccionado { get; private set; }
        public bool QuitarFoto { get; private set; }
        private static readonly Regex RegexCorreo = new(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);
        private static readonly Regex RegexSoloLetras = new(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$", RegexOptions.Compiled);


        public frmEmpleadoModal(EmpleadoController controller, DepartamentosController departamentosController, ServicioFotoEmpleado fotos, Empleado? empleado = null)
        {
            InitializeComponent();
            _controller = controller;
            _departamentosController = departamentosController;
            _fotos = fotos;
            _imagenSinFoto = ServicioFotoEmpleado.CrearImagenSinFoto(100);
            EmpleadoActual = empleado ?? new Empleado();
            Text = empleado == null ? "Nuevo Empleado" : "Editar Empleado";
            ConfigurarBinding();
            MostrarImagen(_fotos.CargarImagen(EmpleadoActual.FotoRuta));

            FormClosed += (_, _) =>
            {
                _imagenTemporal?.Dispose();
                _imagenSinFoto.Dispose();
            };
        }

        private void ConfigurarBinding()
        {
            foreach (Departamento departamento in _departamentosController.ObtenerTodos())
            {
                cmbDepartamentos.Items.Add(departamento.Nombre);
            }

            mtxDUI.DataBindings.Add("Text", EmpleadoActual, nameof(Empleado.Dui), false, DataSourceUpdateMode.OnPropertyChanged);
            txtNombre.DataBindings.Add("Text", EmpleadoActual, nameof(Empleado.Nombre), false, DataSourceUpdateMode.OnPropertyChanged);
            txtApellido.DataBindings.Add("Text", EmpleadoActual, nameof(Empleado.Apellido), false, DataSourceUpdateMode.OnPropertyChanged);
            txtCargo.DataBindings.Add("Text", EmpleadoActual, nameof(Empleado.Cargo), false, DataSourceUpdateMode.OnPropertyChanged);
            cmbDepartamentos.DataBindings.Add("SelectedItem", EmpleadoActual, nameof(Empleado.Departamento), false, DataSourceUpdateMode.OnPropertyChanged);
            txtCorreo.DataBindings.Add("Text", EmpleadoActual, nameof(Empleado.Correo), false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool esValido = true;

            if (!mtxDUI.MaskCompleted)
            {
                errorProvider1.SetError(mtxDUI, "El DUI esta incompleto o se encuentra vacío");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El nombre se encuentra vacío");
                esValido = false;
            }
            else if(!RegexSoloLetras.IsMatch(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El nombre solo puede contener letras y espacios");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                errorProvider1.SetError(txtApellido, "El apellido se encuentra vacío");
                esValido = false;
            }
            else if(!RegexSoloLetras.IsMatch(txtApellido.Text))
            {
                errorProvider1.SetError(txtApellido, "El apellido solo puede contener letras y espacios");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtCargo.Text))
            {
                errorProvider1.SetError(txtCargo, "El cargo se encuentra vacío");
                esValido = false;
            }
            else if (!RegexSoloLetras.IsMatch(txtCargo.Text))
            {
                errorProvider1.SetError(txtCargo, "El cargo solo puede contener letras y espacios");
                esValido = false;
            }

            if (cmbDepartamentos.SelectedItem == null)
            {
                errorProvider1.SetError(cmbDepartamentos, "Debe de escoger un departamento");
                esValido = false;
            }

            if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                errorProvider1.SetError(txtCorreo, "El correo no puede encontrarse vacío");
                esValido = false;
            }
            else if(!RegexCorreo.IsMatch(txtCorreo.Text))
            {
                errorProvider1.SetError(txtCorreo, "El correo no tiene un formato válido");
                esValido = false;
            }

            if (!esValido) return;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            using var dialogo = new OpenFileDialog
            {
                Title = "Seleccionar fotografía del empleado",
                Filter = "Fotografías JPG o PNG|*.jpg;*.jpeg;*.png|Todos los archivos|*.*",
                FilterIndex = 1,
                CheckFileExists = true,
                Multiselect = false
            };

            if (dialogo.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                var archivo = new FileInfo(dialogo.FileName);
                if (archivo.Length == 0 || archivo.Length > 8 * 1024 * 1024)
                    throw new ArgumentException("La imagen no puede superar 8 MB.");

                string extension = archivo.Extension.ToLowerInvariant();
                if (extension is not (".jpg" or ".jpeg" or ".png"))
                    throw new ArgumentException("Seleccione una fotografía JPG o PNG.");

                using var archivoImagen = File.OpenRead(dialogo.FileName);
                using Image original = Image.FromStream(archivoImagen, false, true);
                if (original.Width > 6000 || original.Height > 6000)
                    throw new ArgumentException("La imagen supera las dimensiones máximas permitidas.");

                var vistaPrevia = new Bitmap(original);

                MostrarImagen(vistaPrevia);
                ArchivoFotoSeleccionado = dialogo.FileName;
                QuitarFoto = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo cargar la fotografía.\n\n{ex.Message}",
                    "Imagen no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MostrarImagen(null);
            ArchivoFotoSeleccionado = null;
            QuitarFoto = true;
        }

        private void MostrarImagen(Image? nuevaImagen)
        {
            picFoto.Image = nuevaImagen ?? _imagenSinFoto;
            _imagenTemporal?.Dispose();
            _imagenTemporal = nuevaImagen;
        }

        private void frmEmpleadoModal_Load(object sender, EventArgs e)
        {

        }
    }
}
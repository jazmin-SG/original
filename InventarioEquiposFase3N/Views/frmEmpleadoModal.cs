using InventarioEquiposFase3N.Controllers;
using InventarioEquiposFase3N.Models;
using System;
using System.Windows.Forms;

namespace InventarioEquiposFase3N
{
    public partial class frmEmpleadoModal : Form
    {
        public Empleado EmpleadoActual { get; }
        private readonly EmpleadoController _controller;
        private readonly DepartamentosController _departamentosController;

        public frmEmpleadoModal(EmpleadoController controller, DepartamentosController departamentosController, Empleado? empleado = null)
        {
            InitializeComponent();
            _controller = controller;
            _departamentosController = departamentosController;
            EmpleadoActual = empleado ?? new Empleado();
            Text = empleado == null ? "Nuevo Empleado" : "Editar Empleado";
            ConfigurarBinding();
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

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                errorProvider1.SetError(txtApellido, "El apellido se encuentra vacío");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtCargo.Text))
            {
                errorProvider1.SetError(txtCargo, "El cargo se encuentra vacío");
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

            if (!esValido) return;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
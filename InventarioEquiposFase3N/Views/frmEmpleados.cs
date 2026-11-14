using InventarioEquiposFase3N.Controllers;
using InventarioEquiposFase3N.Models;
using InventarioEquiposFase3N.Services;
using System;
using System.Windows.Forms;

namespace InventarioEquiposFase3N
{
    public partial class frmEmpleados : Form
    {
        private readonly EmpleadoController _controller;
        private readonly DepartamentosController _departamentosController;

        private readonly ServicioFotoEmpleado _fotos;
        private readonly Image _imagenSinFoto;
        private readonly Dictionary<string, Image?> _miniaturas = new(StringComparer.OrdinalIgnoreCase);

        public frmEmpleados(EmpleadoController controller, DepartamentosController departamentosController, ServicioFotoEmpleado fotos)
        {
            InitializeComponent();
            _controller = controller;
            _departamentosController = departamentosController;
            _fotos = fotos;
            _imagenSinFoto = ServicioFotoEmpleado.CrearImagenSinFoto(100);

            ConfigurarDataGrid();
            ActualizarDataGrid();

            this.FormClosed += (s, e) =>
            {
                foreach (Image? imagen in _miniaturas.Values)
                    imagen?.Dispose();
                _miniaturas.Clear();
                _imagenSinFoto.Dispose();
            };

        }

        private void ConfigurarDataGrid()
        {
            dgvEmpleados.AutoGenerateColumns = false;
            dgvEmpleados.Columns.Clear();

            var colFoto = new DataGridViewImageColumn
            {
                Name = "Foto",
                HeaderText = "Foto",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 120,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };

            dgvEmpleados.Columns.Add(colFoto);
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Empleado.Dui), HeaderText = "DUI", FillWeight = 15 });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Empleado.Nombre), HeaderText = "Nombre", FillWeight = 25 });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Empleado.Apellido), HeaderText = "Apellido", FillWeight = 25 });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Empleado.Cargo), HeaderText = "Cargo", FillWeight = 15 });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Empleado.Departamento), HeaderText = "Departamento", FillWeight = 20 });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Empleado.Correo), HeaderText = "Correo", FillWeight = 25 });

            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleados.RowHeadersVisible = false;
            dgvEmpleados.MultiSelect = false;

            dgvEmpleados.RowTemplate.Height = 120;
            dgvEmpleados.CellFormatting += DgvEmpleados_CellFormatting;

        }

        private void DgvEmpleados_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e) 
        {
            if (e.RowIndex < 0 || dgvEmpleados.Columns[e.ColumnIndex].Name != "Foto")
                return;

            if (dgvEmpleados.Rows[e.RowIndex].DataBoundItem is not Empleado empleado)
                return;

            Image? imagen = null;
            if (!string.IsNullOrWhiteSpace(empleado.FotoRuta))
            {
                if (!_miniaturas.TryGetValue(empleado.FotoRuta, out imagen))
                {
                    imagen = _fotos.CrearMiniatura(empleado.FotoRuta, 120, 120);
                    _miniaturas.Add(empleado.FotoRuta, imagen);
                }
            }

            e.Value = imagen ?? _imagenSinFoto;
            e.FormattingApplied = true;
        }

        private void ActualizarDataGrid()
        {
            foreach (var img in _miniaturas.Values) img?.Dispose();
            _miniaturas.Clear();
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = _controller.Buscar(txtBuscarEmpleado.Text);
            dgvEmpleados.Invalidate();
        }

        private void txtBuscarEmpleado_Click(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void toolBtnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            using var dlg = new frmEmpleadoModal(_controller, _departamentosController, _fotos);

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    _controller.Agregar(dlg.EmpleadoActual, dlg.ArchivoFotoSeleccionado);
                    ActualizarDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al guardar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolBtnEditarEmpleados_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow?.DataBoundItem is not Empleado empleadoSeleccionado)
            {
                MessageBox.Show("Seleccione a un empleado de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var copia = new Empleado(empleadoSeleccionado.Id, empleadoSeleccionado.Dui, empleadoSeleccionado.Nombre, empleadoSeleccionado.Apellido, empleadoSeleccionado.Cargo, empleadoSeleccionado.Departamento, empleadoSeleccionado.Correo, empleadoSeleccionado.FotoRuta);

            using var dlg = new frmEmpleadoModal(_controller, _departamentosController, _fotos, copia);

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    _controller.Actualizar(empleadoSeleccionado, dlg.EmpleadoActual, dlg.ArchivoFotoSeleccionado, dlg.QuitarFoto);
                    ActualizarDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolBtnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow?.DataBoundItem is not Empleado empleadoSeleccionado)
            {
                MessageBox.Show("Seleccione un empleado de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var respuesta = MessageBox.Show("¿Está seguro de eliminar este empleado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                _controller.Eliminar(empleadoSeleccionado);
                ActualizarDataGrid();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

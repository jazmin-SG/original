using InventarioEquiposFase3N.Controllers;
using InventarioEquiposFase3N.Models;
using System;
using System.Windows.Forms;

namespace InventarioEquiposFase3N
{
    public partial class frmEmpleados : Form
    {
        private readonly EmpleadoController _controller;
        private readonly DepartamentosController _departamentosController;

        public frmEmpleados(EmpleadoController controller, DepartamentosController departamentosController)
        {
            InitializeComponent();
            _controller = controller;
            _departamentosController = departamentosController;
            ConfigurarDataGrid();
            ActualizarDataGrid();

        }

        private void ConfigurarDataGrid()
        {
            dgvEmpleados.AutoGenerateColumns = false;
            dgvEmpleados.Columns.Clear();

            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Empleado.Dui), HeaderText = "DUI", FillWeight = 15 });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Empleado.Nombre), HeaderText = "Nombre", FillWeight = 25 });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Empleado.Apellido), HeaderText = "Apellido", FillWeight = 25 });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Empleado.Cargo), HeaderText = "Cargo", FillWeight = 15 });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Empleado.Departamento), HeaderText = "Departamento", FillWeight = 20 });
            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Empleado.Correo), HeaderText = "Ddepartamento", FillWeight = 25 });

            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleados.RowHeadersVisible = false;
            dgvEmpleados.MultiSelect = false;

        }

        private void ActualizarDataGrid()
        {
            dgvEmpleados.DataSource = _controller.Buscar(txtBuscarEmpleado.Text);
        }

        private void txtBuscarEmpleado_Click(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void toolBtnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            using var dlg = new frmEmpleadoModal(_controller, _departamentosController);

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    _controller.Agregar(dlg.EmpleadoActual);
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

            var copia = new Empleado(empleadoSeleccionado.Id, empleadoSeleccionado.Dui, empleadoSeleccionado.Nombre, empleadoSeleccionado.Apellido, empleadoSeleccionado.Cargo, empleadoSeleccionado.Departamento, empleadoSeleccionado.Correo);

            using var dlg = new frmEmpleadoModal(_controller, _departamentosController, copia);

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    _controller.Actualizar(empleadoSeleccionado, dlg.EmpleadoActual);
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

using System;
using System.Windows.Forms;
using InventarioEquiposFase3N.Models;
using InventarioEquiposFase3N.Repositorios;
using InventarioEquiposFase3N.Controllers;

namespace InventarioEquiposFase3N
{
    public partial class frmMantenimientos : Form
    {
        private readonly MantenimientoController _controller;

        public frmMantenimientos(MantenimientoController controller)
        {
            InitializeComponent();
            dtgMantenimientos.CellFormatting += dtgMantenimientos_CellFormatting;
            _controller = controller;
            txtBuscarMantenimientos.TextChanged += txtBuscarMantenimiento_TextChanged;

            toolBtnEditarMantenimiento.Click += toolBtnEditarMantenimiento_Click;
            this.Load += FrmMantenimientos_Load;
        }

        private void FrmMantenimientos_Load(object? sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            _controller.Cargar();

            dtgMantenimientos.AutoGenerateColumns = false;

            string busqueda = txtBuscarMantenimientos.Text.Trim();

            dtgMantenimientos.DataSource = null;

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                dtgMantenimientos.DataSource = _controller.ObtenerTodos();
            }
            else
            {
                dtgMantenimientos.DataSource = _controller.Buscar(busqueda);
            }

            ActualizarResumenVisual();
        }

        private void dtgMantenimientos_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dtgMantenimientos.Columns[e.ColumnIndex].DataPropertyName
                != nameof(Mantenimiento.TecnicoResponsable))
                return;

            if (dtgMantenimientos.Rows[e.RowIndex].DataBoundItem
                is not Mantenimiento mantenimiento)
                return;

            if (mantenimiento.TipoMantenimiento == TipoMantenimiento.Preventivo &&
                (string.IsNullOrWhiteSpace(mantenimiento.TecnicoResponsable) ||
                 mantenimiento.TecnicoResponsable.Trim().Equals(
                     "N/A", StringComparison.OrdinalIgnoreCase)))
            {
                e.Value = "No asignado";
                e.FormattingApplied = true;
            }
        }

        private void txtBuscarMantenimiento_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                string busqueda = txtBuscarMantenimientos.Text.Trim();

                dtgMantenimientos.DataSource = null;
                dtgMantenimientos.DataSource = _controller.Buscar(busqueda);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al buscar: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void ActualizarResumenVisual()
        {
            var resumen = _controller.ObtenerResumen();

            lblSuma.Text = $"Total : ${resumen.totalCostos:N2}";
            lblPromedio.Text = $"Promedio : ${resumen.promedioCostos:N2}";
            lblFechaReciente.Text = $"Último: {resumen.ultimoMantenimiento}";
            lblTotalEquipo.Text = $"Cant. por equipo: {resumen.totalRegistros}";
        }


        private void toolBtnNuevoMantenimiento_Click(object sender, EventArgs e)
        {
            frmMantenimientoModal modal = new frmMantenimientoModal();

            if (modal.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    _controller.Agregar(modal.MantenimientoActual);


                    CargarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el mantenimiento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolBtnEliminarMantenimiento_Click(object sender, EventArgs e)
        {

            if (dtgMantenimientos.CurrentRow != null)
            {

                var mantenimientoSeleccionado = dtgMantenimientos.CurrentRow.DataBoundItem as Mantenimiento;

                if (mantenimientoSeleccionado != null)
                {

                    var confirmacion = MessageBox.Show(
                        $"¿Estás seguro de eliminar el mantenimiento del equipo: {mantenimientoSeleccionado.Equipo}?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (confirmacion == DialogResult.Yes)
                    {
                        try
                        {

                            _controller.Eliminar(mantenimientoSeleccionado);


                            CargarDatos();

                            MessageBox.Show("Mantenimiento eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona un registro de la tabla para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolBtnEditarMantenimiento_Click(object? sender, EventArgs e)
        {
            var seleccionado =
                dtgMantenimientos.CurrentRow?.DataBoundItem as Mantenimiento;

            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un mantenimiento para editar.");
                return;
            }

            var copia = new Mantenimiento
            {
                Equipo = seleccionado.Equipo,
                TipoMantenimiento = seleccionado.TipoMantenimiento,
                Fecha = seleccionado.Fecha,
                Descripcion = seleccionado.Descripcion,
                TecnicoResponsable = seleccionado.TecnicoResponsable,
                Costo = seleccionado.Costo
            };

            using var formulario = new frmEditarMantenimiento(copia);

            if (formulario.ShowDialog(this) == DialogResult.OK)
            {
                var anterior = new Mantenimiento
                {
                    Equipo = seleccionado.Equipo,
                    TipoMantenimiento = seleccionado.TipoMantenimiento,
                    Fecha = seleccionado.Fecha,
                    Descripcion = seleccionado.Descripcion,
                    TecnicoResponsable = seleccionado.TecnicoResponsable,
                    Costo = seleccionado.Costo
                };

                try
                {
                    seleccionado.TipoMantenimiento = copia.TipoMantenimiento;
                    seleccionado.Fecha = copia.Fecha;
                    seleccionado.Descripcion = copia.Descripcion;
                    seleccionado.TecnicoResponsable = copia.TecnicoResponsable;
                    seleccionado.Costo = copia.Costo;

                    _controller.Actualizar(seleccionado);
                    CargarDatos();

                    MessageBox.Show(
                        "Mantenimiento actualizado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    seleccionado.TipoMantenimiento = anterior.TipoMantenimiento;
                    seleccionado.Fecha = anterior.Fecha;
                    seleccionado.Descripcion = anterior.Descripcion;
                    seleccionado.TecnicoResponsable = anterior.TecnicoResponsable;
                    seleccionado.Costo = anterior.Costo;

                    MessageBox.Show(
                        $"Error al actualizar: {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
using System;
using System.Windows.Forms;
using InventarioEquiposFase3N.Models;
using InventarioEquiposFase3N.Repositorios;

namespace InventarioEquiposFase3N
{
    public partial class frmMantenimientos : Form
    {
        private readonly RepositorioMantenimientos _repositorio = new RepositorioMantenimientos();

        public frmMantenimientos()
        {
            InitializeComponent();
            this.Load += FrmMantenimientos_Load;
        }

        private void FrmMantenimientos_Load(object? sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {

            _repositorio.Leer();
            dtgMantenimientos.DataSource = _repositorio.ObtenerTodos();
            ActualizarResumenVisual();
        }
        private void ActualizarResumenVisual()
        {
            var resumen = _repositorio.ObtenerResumen();

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

                    _repositorio.Agregar(modal.MantenimientoActual);


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
                            
                            _repositorio.Eliminar(mantenimientoSeleccionado);

                         
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
    }
}

using InventarioEquiposFase3N.Controllers;
using InventarioEquiposFase3N.Models;
using InventarioEquiposFase3N.Repositorios;
using System;
using System.Windows.Forms;

namespace InventarioEquiposFase3N
{
    public partial class frmAsignarEquipos : Form
    {
        private readonly AsignacionController _asignacionController;
        private readonly RepositorioEquipos _repoEquipo;
            
        public frmAsignarEquipos(AsignacionController asignacionController, RepositorioEquipos repoEquipo)
        {
            _asignacionController = asignacionController;
            if (repoEquipo != null)
            {
                _repoEquipo = repoEquipo;
            }
            InitializeComponent();
            ConfigurarTabla();
            cmbEmpleadoAsignar.DisplayMember = nameof(Empleado.Nombre);
            cmbEquipoAsignar.DisplayMember = nameof(Equipo.Codigo);


            cmbEmpleadoAsignar.Items.AddRange(_asignacionController.ObtenerEmpleados().ToArray());
            cmbEquipoAsignar.Items.AddRange(_asignacionController.ObtenerEquipos().ToArray());
        }

        private void ConfigurarTabla()
        {
            dgvHistorialDeAsignaciones.AutoGenerateColumns = false;
            dgvHistorialDeAsignaciones.Columns.Clear();

            dgvHistorialDeAsignaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Asignacion.Equipo), HeaderText = "Código del Equipo", FillWeight = 20 });
            dgvHistorialDeAsignaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Asignacion.Empleado), HeaderText = "DUI del Empleado", FillWeight = 20 });
            dgvHistorialDeAsignaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Asignacion.FechaAsignacion), HeaderText = "Fecha de Asignación", FillWeight = 20 });
            dgvHistorialDeAsignaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Asignacion.FechaDevolucion), HeaderText = "Fecha de Devolución", FillWeight = 20 });
            dgvHistorialDeAsignaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Asignacion.Estado), HeaderText = "Estado", FillWeight = 20 });
            dgvHistorialDeAsignaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Asignacion.Observacion), HeaderText = "Observación", FillWeight = 20 });

            dgvHistorialDeAsignaciones.AllowUserToAddRows = false;
            dgvHistorialDeAsignaciones.AllowUserToDeleteRows = false;
            dgvHistorialDeAsignaciones.ReadOnly = true;
            dgvHistorialDeAsignaciones.MultiSelect = false;
            dgvHistorialDeAsignaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorialDeAsignaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorialDeAsignaciones.RowHeadersVisible = false;

        }

        private void ActualizarTabla()
        {
            dgvHistorialDeAsignaciones.DataSource = _asignacionController.ObtenerTodos();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            bool Ok = true;
            errorProvider1.Clear();
            if (dtpFechaDevolucion.Value < dtpFecha.Value)
            {
                MessageBox.Show("La fecha de devolución no puede ser anterior a la fecha de asignación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(dtpFecha, "Ingrese una fecha valida");
                Ok = false;

            }
            if (string.IsNullOrWhiteSpace(txtObservaciones.Text))
            {

                MessageBox.Show("Debe ingresar una observación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txtObservaciones, "Digite una observacion");
                Ok = false;

            }

            if (cmbEmpleadoAsignar.SelectedItem is not Empleado empleadoSeleccionado)
            {
                MessageBox.Show("Seleccione un empleado válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (cmbEquipoAsignar.SelectedItem is not Equipo equipoSeleccionado)
            {
                MessageBox.Show("Seleccione un equipo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Ok)
            {
                return;
            }





            var estadoActual = equipoSeleccionado.Estado;
            var nuevaAsignacion = new Asignacion
            {
                Empleado = empleadoSeleccionado.Nombre,
                Equipo = equipoSeleccionado.Codigo,
                FechaAsignacion = dtpFecha.Value,
                FechaDevolucion = dtpFechaDevolucion.Value,
                Observacion = txtObservaciones.Text,
                Estado = equipoSeleccionado.Estado.ToString()

            };
            _asignacionController.Agregar(nuevaAsignacion);

            equipoSeleccionado.Estado = Estado.Asignado;


            MessageBox.Show("Equipo asignado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ActualizarTabla();
        }

        private void btnDevolverEquipo_Click(object sender, EventArgs e)
        {
            if (dgvHistorialDeAsignaciones.CurrentRow?.DataBoundItem is not Asignacion asignacionSeleccionada)
            {
                MessageBox.Show("Seleccione una asignación de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {

                if (_repoEquipo == null)
                {
                    MessageBox.Show("Error interno: El repositorio de equipos no ha sido inicializado.", "Error crítico");
                    return;
                }

                var equipo = _repoEquipo.BuscarPorCodigo(asignacionSeleccionada.Equipo);

                if (equipo != null)
                {
                    equipo.Estado = Estado.Disponible;
                    _repoEquipo.Actualizar(equipo);
                }
                else
                {
                    MessageBox.Show("No se encontró el equipo en la base de datos (la lista está vacía).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _asignacionController.Eliminar(asignacionSeleccionada);

                MessageBox.Show("Equipo devuelto a estado 'Disponible' y asignación eliminada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ActualizarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al devolver: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {

            if (dgvHistorialDeAsignaciones.CurrentRow?.DataBoundItem is not Asignacion asignacionSeleccionada)
            {
                MessageBox.Show("Seleccione una asignación de la lista para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            var copia = new Asignacion
            {
                IdAsignacion = asignacionSeleccionada.IdAsignacion,
                Empleado = asignacionSeleccionada.Empleado,
                Equipo = asignacionSeleccionada.Equipo,
                FechaAsignacion = asignacionSeleccionada.FechaAsignacion,
                FechaDevolucion = asignacionSeleccionada.FechaDevolucion,
                Observacion = asignacionSeleccionada.Observacion,
                Estado = asignacionSeleccionada.Estado
            };

            using var dlg = new frmEditarAsignacion(_asignacionController, _repoEquipo, copia);

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                try
                {

                    _asignacionController.Actualizar(asignacionSeleccionada, dlg.AsignacionActual);
                    ActualizarTabla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbEquipoAsignar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEquipoAsignar.SelectedItem is Equipo equipoSeleccionado)
            {

                cmbEstadoEquipo.Text = equipoSeleccionado.Estado.ToString();

            }
            else
            {
                cmbEstadoEquipo.Text = string.Empty;

            }
        }
    }

}
    


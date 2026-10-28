
using InventarioEquiposFase3N.Controllers;
using InventarioEquiposFase3N.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventarioEquiposFase3N
{
    public partial class frmEquipos : Form
    {
        private readonly EquiposController _Controller;
        public frmEquipos(EquiposController Controller)
        {
            InitializeComponent();
            _Controller = Controller;
            configurarDataGrid();
            ActualizarDataGrid();
        }
        private void configurarDataGrid()
        {
            dgvEquipos.AutoGenerateColumns = false;
            dgvEquipos.Columns.Clear();
            dgvEquipos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Equipo.Codigo), HeaderText = "Código", FillWeight = 15 });
            dgvEquipos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Equipo.Marca), HeaderText = "Marca", FillWeight = 20 });
            dgvEquipos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Equipo.Modelo), HeaderText = "Modelo", FillWeight = 20 });
            dgvEquipos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Equipo.NumeroSerie), HeaderText = "Número de Serie", FillWeight = 20 });
            dgvEquipos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Equipo.TipoEquipo), HeaderText = "Tipo de Equipo", FillWeight = 20 });
            dgvEquipos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Equipo.Estado), HeaderText = "Estado", FillWeight = 15 });
            dgvEquipos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Equipo.FechaCompra), HeaderText = "Fecha de Compra", FillWeight = 20 });
            dgvEquipos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(Equipo.AnioGarantia), HeaderText = "Año de Garantía", FillWeight = 20 });
            dgvEquipos.AllowUserToAddRows = false;
            dgvEquipos.AllowUserToDeleteRows = false;
            dgvEquipos.ReadOnly = true;
            dgvEquipos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEquipos.RowHeadersVisible = false;
            dgvEquipos.MultiSelect = false;
        }
        private void ActualizarDataGrid()
        {
            dgvEquipos.DataSource = _Controller.ObtenerTodos();
        }

        private void toolBtnNuevoEquipo_Click(object sender, EventArgs e)
        {
            using var dlg = new frmEquipoModal(_Controller);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _Controller.Agregar(dlg.EquipoActual);
                    ActualizarDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar el equipo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolBtnEditarEquipo_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.CurrentRow?.DataBoundItem is not Equipo equipoSeleccionado)
            {
                MessageBox.Show("Seleccione un equipo de la lista",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var copiaEquipo = new Equipo( equipoSeleccionado.Codigo, equipoSeleccionado.Marca,equipoSeleccionado.Modelo, equipoSeleccionado.NumeroSerie,equipoSeleccionado.TipoEquipo,equipoSeleccionado.Estado,equipoSeleccionado.FechaCompra,equipoSeleccionado.AnioGarantia);
            using var dlg = new frmEquipoModal(_Controller, copiaEquipo);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _Controller.Actualizar(equipoSeleccionado, dlg.EquipoActual);
                    ActualizarDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el equipo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void toolBtnEliminarEquipo_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.CurrentRow?.DataBoundItem is not Equipo equipoSeleccionado)
            {
                MessageBox.Show("Seleccione un equipo para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var respuesta = MessageBox.Show($"¿Está seguro de eliminar el equipo con código {equipoSeleccionado.Codigo}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    _Controller.Eliminar(equipoSeleccionado);
                    ActualizarDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el equipo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


using InventarioEquiposFase3N.Controllers;
using InventarioEquiposFase3N.Models;
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace InventarioEquiposFase3N
{
    public partial class frmEquipoModal : Form
    {
        public Equipo EquipoActual { get; }

        private readonly EquiposController _Controller;
        public frmEquipoModal(EquiposController equiposController, Equipo? equipo = null)
        {
            InitializeComponent();
            _Controller = equiposController;
            EquipoActual = equipo ?? new Equipo();
            Text = equipo == null ? "Nuevo Equipo" : "Editar Equipo";
            txtCodigo.ReadOnly = equipo != null;
            Regex regex = new Regex(@"^[A-Z]{2}-\d{3}$");
            ConfigurarBinding();
        }
        public void ConfigurarBinding()
        {
            cmbTipoEquipo.DataSource = Enum.GetValues(typeof(TipoEquipo));
            cmbEstado.DataSource = Enum.GetValues(typeof(Estado));
            txtCodigo.DataBindings.Add("Text", EquipoActual, nameof(Equipo.Codigo), false, DataSourceUpdateMode.OnPropertyChanged);
            txtMarca.DataBindings.Add("Text", EquipoActual, nameof(Equipo.Marca), false, DataSourceUpdateMode.OnPropertyChanged);
            txtModelo.DataBindings.Add("Text", EquipoActual, nameof(Equipo.Modelo), false, DataSourceUpdateMode.OnPropertyChanged);
            txtNumeroSerie.DataBindings.Add("Text", EquipoActual, nameof(Equipo.NumeroSerie), false, DataSourceUpdateMode.OnPropertyChanged);
            cmbTipoEquipo.DataBindings.Add("SelectedItem", EquipoActual, nameof(Equipo.TipoEquipo), false, DataSourceUpdateMode.OnPropertyChanged);
            cmbEstado.DataBindings.Add("SelectedItem", EquipoActual, nameof(Equipo.Estado), false, DataSourceUpdateMode.OnPropertyChanged);
            dtpFechaCompra.DataBindings.Add("Value", EquipoActual, nameof(Equipo.FechaCompra), false, DataSourceUpdateMode.OnPropertyChanged);
            nudAnioGarantia.DataBindings.Add("Value", EquipoActual, nameof(Equipo.AnioGarantia), false, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

            bool esValido = true;
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                errorProvider1.SetError(txtCodigo, "El código no puede estar vacío");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                errorProvider1.SetError(txtMarca, "La marca no puede estar vacía");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                errorProvider1.SetError(txtModelo, "El modelo no puede estar vacío");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtNumeroSerie.Text))
            {
                errorProvider1.SetError(txtNumeroSerie, "El número de serie no puede estar vacío");
                esValido = false;
            }
            if (esValido)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void txtCodigo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtCodigo.Text, @"^[A-Z]{2}-\d{3}$"))
            {
                errorProvider1.SetError(txtCodigo, "El código debe tener el formato: (Ejemplo: AQ-123)");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtCodigo, "");
            }
        }
    }

}

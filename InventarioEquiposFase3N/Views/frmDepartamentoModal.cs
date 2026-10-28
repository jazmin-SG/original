using System;
using System.Windows.Forms;

namespace InventarioEquiposFase3N
{
    public partial class frmDepartamentoModal : Form
    {
        public string Codigo { get; private set; } = string.Empty;
        public string Nombre { get; private set; } = string.Empty;
        public string Ubicacion { get; private set; } = string.Empty;
        public string Encargado { get; private set; } = string.Empty;

        public frmDepartamentoModal()
        {
            InitializeComponent();
        }

        private void frmDepartamentoModal_Load(object sender, EventArgs e)
        {
            txtCodigo.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool valido = true;

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                errorProvider1.SetError(txtCodigo, "Ingrese el código.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese el nombre.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtUbicacion.Text))
            {
                errorProvider1.SetError(txtUbicacion, "Ingrese la ubicación.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtEncargado.Text))
            {
                errorProvider1.SetError(txtEncargado, "Ingrese el encargado.");
                valido = false;
            }

            if (!valido)
            {
                return;
            }


            Codigo = txtCodigo.Text.Trim();
            Nombre = txtNombre.Text.Trim();
            Ubicacion = txtUbicacion.Text.Trim();
            Encargado = txtEncargado.Text.Trim();

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
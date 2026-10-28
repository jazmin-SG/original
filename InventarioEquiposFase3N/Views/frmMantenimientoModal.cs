using System;
using System.Windows.Forms;
using InventarioEquiposFase3N.Models;

namespace InventarioEquiposFase3N
{
    public partial class frmMantenimientoModal : Form
    {
        public Mantenimiento MantenimientoActual = new Mantenimiento();

        public frmMantenimientoModal()
        {
            InitializeComponent();
            MantenimientoActual = new Mantenimiento();
            comboBox1.DataSource = Enum.GetValues(typeof(TipoMantenimiento));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(cmbEquipo.Text))
            {
                MessageBox.Show("Por favor, selecciona o ingresa el equipo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEquipo.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor, ingresa una descripción del mantenimiento.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(txtCosto.Text) || !decimal.TryParse(txtCosto.Text, out decimal costoValidado))
            {
                MessageBox.Show("Por favor, ingresa un costo válido en formato numérico.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCosto.Focus();
                txtCosto.SelectAll();
                return;
            }


            if (comboBox1.SelectedItem is TipoMantenimiento tipoSel)
            {

                if (tipoSel.ToString() != "Preventivo" && string.IsNullOrWhiteSpace(txtResponsable.Text))
                {
                    MessageBox.Show("Para este tipo de mantenimiento, el técnico responsable es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtResponsable.Focus();
                    return;
                }
            }


            MantenimientoActual.Equipo = cmbEquipo.Text.Trim();

            if (comboBox1.SelectedItem is TipoMantenimiento tipoSeleccionado)
            {
                MantenimientoActual.TipoMantenimiento = tipoSeleccionado;
            }

            MantenimientoActual.Fecha = dtpFecha.Value;
            MantenimientoActual.Descripcion = txtDescripcion.Text.Trim();
            MantenimientoActual.TecnicoResponsable = string.IsNullOrWhiteSpace(txtResponsable.Text) ? "N/A" : txtResponsable.Text.Trim();


            MantenimientoActual.Costo = costoValidado.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
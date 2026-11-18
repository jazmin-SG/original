
using System;
using System.Windows.Forms;
using InventarioEquiposFase3N.Models;

namespace InventarioEquiposFase3N
{
    public partial class frmEditarMantenimiento : Form
    {
        private readonly Mantenimiento _mantenimiento;

        public frmEditarMantenimiento(Mantenimiento mantenimiento)
        {
            InitializeComponent();

            _mantenimiento = mantenimiento;

            comboBox1.Items.Add(mantenimiento.Equipo);
            comboBox1.SelectedIndex = 0;
            comboBox1.Enabled = false;

            checkBox1.Checked =
                mantenimiento.TipoMantenimiento == TipoMantenimiento.Preventivo;

            checkBox2.Checked =
                mantenimiento.TipoMantenimiento == TipoMantenimiento.Correctivo;

            dateTimePicker1.Value = mantenimiento.Fecha;
            textBox1.Text = mantenimiento.Descripcion;
            textBox2.Text = mantenimiento.TecnicoResponsable;
            textBox3.Text = mantenimiento.Costo;

            btnGuardar.Click += btnGuardar_Click;
            btnSalir.Click += btnSalir_Click;

            checkBox1.CheckedChanged += (s, e) =>
            {
                if (checkBox1.Checked)
                    checkBox2.Checked = false;
            };

            checkBox2.CheckedChanged += (s, e) =>
            {
                if (checkBox2.Checked)
                    checkBox1.Checked = false;
            };
        }

        private void btnGuardar_Click(object? sender, EventArgs e)
        {
            if (!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Seleccione un tipo de mantenimiento.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Complete los campos obligatorios.");
                return;
            }

            if (checkBox2.Checked &&
                string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show(
                    "Debe ingresar un técnico responsable para el mantenimiento correctivo.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            _mantenimiento.TipoMantenimiento =
                checkBox2.Checked
                    ? TipoMantenimiento.Correctivo
                    : TipoMantenimiento.Preventivo;

            _mantenimiento.Fecha = dateTimePicker1.Value;
            _mantenimiento.Descripcion = textBox1.Text.Trim();
            _mantenimiento.TecnicoResponsable = textBox2.Text.Trim();
            _mantenimiento.Costo = textBox3.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnSalir_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

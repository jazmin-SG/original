
using InventarioEquiposFase3N.Controllers;
using InventarioEquiposFase3N.Models;
using System;
using System.Windows.Forms;

namespace InventarioEquiposFase3N
{
    public partial class frmConsultas : Form
    {
        private readonly EquiposController _equiposController;
        private System.Windows.Forms.Timer _timerBusqueda;
        public frmConsultas(EquiposController equiposController)
        {
            InitializeComponent();
            _equiposController = equiposController;
            _timerBusqueda = new System.Windows.Forms.Timer();
            _timerBusqueda.Interval = 400;
            _timerBusqueda.Tick += TimerBusqueda_Tick;
            configurarDataGrid();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {

            
            cmbEstado.DataSource = Enum.GetValues<Estado>().Cast<object>().ToList().Prepend("Todas").ToList();

            cmbEstado.SelectedIndex = -1;


            dtpFecha.ShowCheckBox = true;
            dtpFecha.Checked = false;

            txtCodigo.TextChanged += ControlesBusqueda_Cambiaron;
            cmbEstado.SelectedIndexChanged += ControlesBusqueda_Cambiaron;
            dtpFecha.ValueChanged += ControlesBusqueda_Cambiaron;


            EjecutarBusqueda();
        }

        private void ControlesBusqueda_Cambiaron(object sender, EventArgs e)
        {
            _timerBusqueda.Stop();
            _timerBusqueda.Start();
        }

        private void TimerBusqueda_Tick(object sender, EventArgs e)
        {
            _timerBusqueda.Stop();
            EjecutarBusqueda();
        }

        private void EjecutarBusqueda()
        {
            try
            {
                string codigo = txtCodigo.Text.Trim();

                Estado? estadoSeleccionado = null;
                if (cmbEstado.SelectedItem is Estado estado)
                {
                    estadoSeleccionado = estado;
                }

                DateTime? fechaSeleccionada = null;
                if (dtpFecha.Checked)
                {
                    fechaSeleccionada = dtpFecha.Value;
                }


                var resultados = _equiposController.BuscarEquipos(codigo, estadoSeleccionado, fechaSeleccionada);



                dgvEquipos.DataSource = resultados;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

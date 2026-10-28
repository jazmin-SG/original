
using InventarioEquiposFase3N.Controllers;
using InventarioEquiposFase3N.Models;
using InventarioEquiposFase3N.Repositorios;
using System;
using System.Windows.Forms;

namespace InventarioEquiposFase3N
{
    public partial class frmEditarAsignacion : Form
    {
        private readonly AsignacionController _controller;
        private readonly RepositorioEquipos _repoEquipo;


        public Asignacion AsignacionActual { get; private set; }
        public frmEditarAsignacion(AsignacionController controller, RepositorioEquipos repoEquipo, Asignacion copia)
        {

            InitializeComponent();
            _controller = controller;
            _repoEquipo = repoEquipo;
            AsignacionActual = copia;
            txtObservaciones.DataBindings.Add("Text", AsignacionActual, nameof(AsignacionActual.Observacion), false, DataSourceUpdateMode.OnPropertyChanged);



            cmbEmpleado.DisplayMember = nameof(Empleado.Nombre);
            cmbEmpleado.Items.AddRange(_controller.ObtenerEmpleados().ToArray());

            cmbEquipo.DisplayMember = nameof(Equipo.Codigo);
            cmbEquipo.Items.AddRange(_repoEquipo.ObtenerTodos().ToArray());
        }

        private void frmEditarAsignacion_Load(object sender, EventArgs e)
        {

            var empleado = _controller.ObtenerEmpleados().FirstOrDefault(x => x.Dui == AsignacionActual.Empleado);
            cmbEmpleado.SelectedItem = empleado;


            var equipo = _repoEquipo.BuscarPorCodigo(AsignacionActual.Equipo);
            cmbEquipo.SelectedItem = equipo;


            dtpFechaAsignacion.Value = AsignacionActual.FechaAsignacion;
            dtpFechaDevolucion.Value = AsignacionActual.FechaDevolucion;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbEmpleado.SelectedItem is not Empleado empleado ||
                cmbEquipo.SelectedItem is not Equipo equipo)
            {
                MessageBox.Show("Debe seleccionar un empleado y un equipo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpFechaDevolucion.Value < dtpFechaAsignacion.Value)
            {
                MessageBox.Show("La fecha de devolución no puede ser anterior a la de asignación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            AsignacionActual.Empleado = empleado.Nombre;
            AsignacionActual.Equipo = equipo.Codigo;
            AsignacionActual.FechaAsignacion = dtpFechaAsignacion.Value;
            AsignacionActual.FechaDevolucion = dtpFechaDevolucion.Value;


            DialogResult = DialogResult.OK;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}



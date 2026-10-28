using InventarioEquiposFase3N.Controllers;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace InventarioEquiposFase3N
{
    public partial class frmPrincipal : Form
    {
        private readonly Controllers.EmpleadoController _empleadoController;
        private readonly Controllers.EquiposController _equiposController;

        private readonly Controllers.AsignacionController _asignacionController;

        private readonly Repositorios.RepositorioEquipos _repoEquipos;

        private readonly Controllers.DepartamentosController _departamentosController;

        public frmPrincipal(Controllers.EmpleadoController empleadoController, Controllers.EquiposController equiposController, Controllers.AsignacionController asignacionController, Repositorios.RepositorioEquipos repoEquiposs, Controllers.DepartamentosController departamentosController)
        {
            InitializeComponent();

            _empleadoController = empleadoController;
            _equiposController = equiposController;
            _asignacionController = asignacionController;
            _repoEquipos = repoEquiposs;
            _departamentosController = departamentosController;

            pictureBox1.BackColor = Color.FromArgb(248, 249, 250);

            foreach (Control control in this.Controls)
            {
                if (control is MdiClient mdiClient)
                {
                    mdiClient.BackColor = Color.FromArgb(248, 249, 250);
                }
            }
        }

        private void mnuEquipo_Click(object sender, EventArgs e)
        {
            frmEquipos frm = new frmEquipos(_equiposController);
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuEmpleado_Click(object sender, EventArgs e)
        {
            frmEmpleados frm = new frmEmpleados(_empleadoController, _departamentosController);
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuDepartamento_Click(object sender, EventArgs e)
        {
            frmDepartamentos frm = new frmDepartamentos(_departamentosController);
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuMantenimiento_Click(object sender, EventArgs e)
        {
            frmMantenimientos frm = new frmMantenimientos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuAsignarEquipos_Click(object sender, EventArgs e)
        {
            frmAsignarEquipos frm = new frmAsignarEquipos(_asignacionController, _repoEquipos);
            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuConsultas_Click(object sender, EventArgs e)
        {
            frmConsultas frm = new frmConsultas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolBtnEquipos_Click(object sender, EventArgs e)
        {
            mnuEquipo_Click(sender, e);
        }

        private void toolBtnEmpleados_Click(object sender, EventArgs e)
        {
            mnuEmpleado_Click(sender, e);
        }

        private void toolBtnDepartamentos_Click(object sender, EventArgs e)
        {
            mnuDepartamento_Click(sender, e);
        }

        private void toolBtnMantenimiento_Click(object sender, EventArgs e)
        {
            mnuMantenimiento_Click(sender, e);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MnuConsultas_Click(sender, e);
        }

        private void cacadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuCerrarTodo_Click(object sender, EventArgs e)
        {
            foreach (Form frm in MdiChildren)
            {
                frm.Close();
            }
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPrincipal_MdiChildActivate(object sender, EventArgs e)
        {
            pictureBox1.Visible = ActiveMdiChild == null;
        }
    }
}
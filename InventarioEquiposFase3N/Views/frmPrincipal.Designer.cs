
namespace InventarioEquiposFase3N
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            menuStrip1 = new MenuStrip();
            mnuFormularios = new ToolStripMenuItem();
            mnuEquipo = new ToolStripMenuItem();
            mnuEmpleado = new ToolStripMenuItem();
            mnuDepartamento = new ToolStripMenuItem();
            mnuMantenimiento = new ToolStripMenuItem();
            mnuOrganizar = new ToolStripMenuItem();
            mnuCascada = new ToolStripMenuItem();
            mnuVertical = new ToolStripMenuItem();
            mnuHorizontal = new ToolStripMenuItem();
            mnuCerrarTodo = new ToolStripMenuItem();
            mnuAsignarEquipos = new ToolStripMenuItem();
            MnuConsultas = new ToolStripMenuItem();
            mnuSalir = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolBtnEquipos = new ToolStripButton();
            toolBtnEmpleados = new ToolStripButton();
            toolBtnDepartamentos = new ToolStripButton();
            toolBtnMantenimiento = new ToolStripButton();
            toolbtnConsultas = new ToolStripButton();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(205, 220, 238);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFormularios, mnuOrganizar, mnuAsignarEquipos, MnuConsultas, mnuSalir });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(969, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFormularios
            // 
            mnuFormularios.DropDownItems.AddRange(new ToolStripItem[] { mnuEquipo, mnuEmpleado, mnuDepartamento, mnuMantenimiento });
            mnuFormularios.Name = "mnuFormularios";
            mnuFormularios.Size = new Size(101, 24);
            mnuFormularios.Text = "Formularios";
            // 
            // mnuEquipo
            // 
            mnuEquipo.Name = "mnuEquipo";
            mnuEquipo.Size = new Size(193, 26);
            mnuEquipo.Text = "Equipo";
            mnuEquipo.Click += mnuEquipo_Click;
            // 
            // mnuEmpleado
            // 
            mnuEmpleado.Name = "mnuEmpleado";
            mnuEmpleado.Size = new Size(193, 26);
            mnuEmpleado.Text = "Empleado";
            mnuEmpleado.Click += mnuEmpleado_Click;
            // 
            // mnuDepartamento
            // 
            mnuDepartamento.Name = "mnuDepartamento";
            mnuDepartamento.Size = new Size(193, 26);
            mnuDepartamento.Text = "Departamento";
            mnuDepartamento.Click += mnuDepartamento_Click;
            // 
            // mnuMantenimiento
            // 
            mnuMantenimiento.Name = "mnuMantenimiento";
            mnuMantenimiento.Size = new Size(193, 26);
            mnuMantenimiento.Text = "Mantenimiento";
            mnuMantenimiento.Click += mnuMantenimiento_Click;
            // 
            // mnuOrganizar
            // 
            mnuOrganizar.DropDownItems.AddRange(new ToolStripItem[] { mnuCascada, mnuVertical, mnuHorizontal, mnuCerrarTodo });
            mnuOrganizar.Name = "mnuOrganizar";
            mnuOrganizar.Size = new Size(88, 24);
            mnuOrganizar.Text = "Organizar";
            // 
            // mnuCascada
            // 
            mnuCascada.Name = "mnuCascada";
            mnuCascada.Size = new Size(219, 26);
            mnuCascada.Text = "Cascada";
            mnuCascada.Click += cacadaToolStripMenuItem_Click;
            // 
            // mnuVertical
            // 
            mnuVertical.Name = "mnuVertical";
            mnuVertical.Size = new Size(219, 26);
            mnuVertical.Text = "Mosaico vertical";
            mnuVertical.Click += mnuVertical_Click;
            // 
            // mnuHorizontal
            // 
            mnuHorizontal.Name = "mnuHorizontal";
            mnuHorizontal.Size = new Size(219, 26);
            mnuHorizontal.Text = "Mosaico horizontal";
            mnuHorizontal.Click += mnuHorizontal_Click;
            // 
            // mnuCerrarTodo
            // 
            mnuCerrarTodo.Name = "mnuCerrarTodo";
            mnuCerrarTodo.Size = new Size(219, 26);
            mnuCerrarTodo.Text = "Cerrar todo";
            mnuCerrarTodo.Click += mnuCerrarTodo_Click;
            // 
            // mnuAsignarEquipos
            // 
            mnuAsignarEquipos.Name = "mnuAsignarEquipos";
            mnuAsignarEquipos.Size = new Size(130, 24);
            mnuAsignarEquipos.Text = "Asignar Equipos";
            mnuAsignarEquipos.Click += mnuAsignarEquipos_Click;
            // 
            // MnuConsultas
            // 
            MnuConsultas.Name = "MnuConsultas";
            MnuConsultas.Size = new Size(86, 24);
            MnuConsultas.Text = "Consultas";
            MnuConsultas.Click += MnuConsultas_Click;
            // 
            // mnuSalir
            // 
            mnuSalir.Name = "mnuSalir";
            mnuSalir.Size = new Size(52, 24);
            mnuSalir.Text = "Salir";
            mnuSalir.Click += mnuSalir_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = SystemColors.Control;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(40, 40);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolBtnEquipos, toolBtnEmpleados, toolBtnDepartamentos, toolBtnMantenimiento, toolbtnConsultas });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(969, 103);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolBtnEquipos
            // 
            toolBtnEquipos.AutoSize = false;
            toolBtnEquipos.Image = (Image)resources.GetObject("toolBtnEquipos.Image");
            toolBtnEquipos.ImageTransparentColor = Color.Magenta;
            toolBtnEquipos.Margin = new Padding(12, 1, 12, 2);
            toolBtnEquipos.Name = "toolBtnEquipos";
            toolBtnEquipos.Size = new Size(110, 65);
            toolBtnEquipos.Text = "Equipos";
            toolBtnEquipos.TextImageRelation = TextImageRelation.ImageAboveText;
            toolBtnEquipos.ToolTipText = "Abrir modulo de equipo";
            toolBtnEquipos.Click += toolBtnEquipos_Click;
            // 
            // toolBtnEmpleados
            // 
            toolBtnEmpleados.AutoSize = false;
            toolBtnEmpleados.Image = (Image)resources.GetObject("toolBtnEmpleados.Image");
            toolBtnEmpleados.ImageTransparentColor = Color.Magenta;
            toolBtnEmpleados.Margin = new Padding(12, 1, 12, 2);
            toolBtnEmpleados.Name = "toolBtnEmpleados";
            toolBtnEmpleados.Size = new Size(110, 65);
            toolBtnEmpleados.Text = "Empleados";
            toolBtnEmpleados.TextImageRelation = TextImageRelation.ImageAboveText;
            toolBtnEmpleados.ToolTipText = "Abrir modulo de empleos";
            toolBtnEmpleados.Click += toolBtnEmpleados_Click;
            // 
            // toolBtnDepartamentos
            // 
            toolBtnDepartamentos.AutoSize = false;
            toolBtnDepartamentos.Image = (Image)resources.GetObject("toolBtnDepartamentos.Image");
            toolBtnDepartamentos.ImageTransparentColor = Color.Magenta;
            toolBtnDepartamentos.Margin = new Padding(12, 1, 12, 2);
            toolBtnDepartamentos.Name = "toolBtnDepartamentos";
            toolBtnDepartamentos.Size = new Size(110, 65);
            toolBtnDepartamentos.Text = "Departamentos";
            toolBtnDepartamentos.TextImageRelation = TextImageRelation.ImageAboveText;
            toolBtnDepartamentos.ToolTipText = "Abrir modulo de apartamento";
            toolBtnDepartamentos.Click += toolBtnDepartamentos_Click;
            // 
            // toolBtnMantenimiento
            // 
            toolBtnMantenimiento.AutoSize = false;
            toolBtnMantenimiento.Image = (Image)resources.GetObject("toolBtnMantenimiento.Image");
            toolBtnMantenimiento.ImageTransparentColor = Color.Magenta;
            toolBtnMantenimiento.Margin = new Padding(12, 1, 12, 2);
            toolBtnMantenimiento.Name = "toolBtnMantenimiento";
            toolBtnMantenimiento.Size = new Size(110, 65);
            toolBtnMantenimiento.Text = "Mantenimiento";
            toolBtnMantenimiento.TextImageRelation = TextImageRelation.ImageAboveText;
            toolBtnMantenimiento.ToolTipText = "Abrir mantenimiento";
            toolBtnMantenimiento.Click += toolBtnMantenimiento_Click;
            // 
            // toolbtnConsultas
            // 
            toolbtnConsultas.AutoSize = false;
            toolbtnConsultas.Image = (Image)resources.GetObject("toolbtnConsultas.Image");
            toolbtnConsultas.ImageTransparentColor = Color.Magenta;
            toolbtnConsultas.Margin = new Padding(12, 1, 12, 2);
            toolbtnConsultas.Name = "toolbtnConsultas";
            toolbtnConsultas.Size = new Size(110, 65);
            toolbtnConsultas.Text = "Consultas";
            toolbtnConsultas.TextImageRelation = TextImageRelation.ImageAboveText;
            toolbtnConsultas.ToolTipText = "Abrir modulo de consultas";
            toolbtnConsultas.Click += toolStripButton1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(111, 187);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(696, 390);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(969, 580);
            Controls.Add(pictureBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "InfoStock";
            WindowState = FormWindowState.Maximized;
            MdiChildActivate += frmPrincipal_MdiChildActivate;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFormularios;
        private ToolStripMenuItem mnuEquipo;
        private ToolStripMenuItem mnuEmpleado;
        private ToolStripMenuItem mnuDepartamento;
        private ToolStripMenuItem mnuMantenimiento;
        private ToolStripMenuItem mnuOrganizar;
        private ToolStripMenuItem mnuCascada;
        private ToolStripMenuItem mnuVertical;
        private ToolStripMenuItem mnuHorizontal;
        private ToolStripMenuItem mnuCerrarTodo;
        private ToolStripMenuItem mnuSalir;
        private ToolStrip toolStrip1;
        private ToolStripButton toolBtnEquipos;
        private ToolStripButton toolBtnEmpleados;
        private ToolStripButton toolBtnDepartamentos;
        private ToolStripButton toolBtnMantenimiento;
        private ToolStripMenuItem mnuAsignarEquipos;
        private ToolStripMenuItem MnuConsultas;
        private ToolStripButton toolbtnConsultas;
        private PictureBox pictureBox1;
    }
}

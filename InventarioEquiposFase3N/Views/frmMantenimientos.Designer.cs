
namespace InventarioEquiposFase3N
{
    partial class frmMantenimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            toolBtnNuevoMantenimiento = new ToolStripButton();
            toolBtnEditarMantenimiento = new ToolStripButton();
            toolBtnEliminarMantenimiento = new ToolStripButton();
            dtgMantenimientos = new DataGridView();
            Equipo = new DataGridViewTextBoxColumn();
            TipoDeMantenimiento = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Tecnico = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            btnSalir = new Button();
            lblSuma = new Label();
            lblPromedio = new Label();
            lblFechaReciente = new Label();
            lblTotalEquipo = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMantenimientos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.GradientActiveCaption;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolBtnNuevoMantenimiento, toolBtnEditarMantenimiento, toolBtnEliminarMantenimiento });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1000, 34);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolBtnNuevoMantenimiento
            // 
            toolBtnNuevoMantenimiento.Image = Properties.Resources.plus;
            toolBtnNuevoMantenimiento.ImageTransparentColor = Color.Magenta;
            toolBtnNuevoMantenimiento.Name = "toolBtnNuevoMantenimiento";
            toolBtnNuevoMantenimiento.Size = new Size(88, 29);
            toolBtnNuevoMantenimiento.Text = "Nuevo";
            toolBtnNuevoMantenimiento.Click += toolBtnNuevoMantenimiento_Click;
            // 
            // toolBtnEditarMantenimiento
            // 
            toolBtnEditarMantenimiento.Image = Properties.Resources.boton_editar;
            toolBtnEditarMantenimiento.ImageTransparentColor = Color.Magenta;
            toolBtnEditarMantenimiento.Name = "toolBtnEditarMantenimiento";
            toolBtnEditarMantenimiento.Size = new Size(81, 29);
            toolBtnEditarMantenimiento.Text = "Editar";
            // 
            // toolBtnEliminarMantenimiento
            // 
            toolBtnEliminarMantenimiento.Image = (Image)resources.GetObject("toolBtnEliminarMantenimiento.Image");
            toolBtnEliminarMantenimiento.ImageTransparentColor = Color.Magenta;
            toolBtnEliminarMantenimiento.Name = "toolBtnEliminarMantenimiento";
            toolBtnEliminarMantenimiento.Size = new Size(98, 29);
            toolBtnEliminarMantenimiento.Text = "Eliminar";
            toolBtnEliminarMantenimiento.Click += toolBtnEliminarMantenimiento_Click;
            // 
            // dtgMantenimientos
            // 
            dtgMantenimientos.AllowUserToAddRows = false;
            dtgMantenimientos.AllowUserToDeleteRows = false;
            dtgMantenimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgMantenimientos.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(220, 232, 245);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgMantenimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgMantenimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMantenimientos.Columns.AddRange(new DataGridViewColumn[] { Equipo, TipoDeMantenimiento, Fecha, Descripcion, Tecnico, Costo });
            dtgMantenimientos.EnableHeadersVisualStyles = false;
            dtgMantenimientos.Location = new Point(0, 49);
            dtgMantenimientos.Margin = new Padding(4);
            dtgMantenimientos.Name = "dtgMantenimientos";
            dtgMantenimientos.ReadOnly = true;
            dtgMantenimientos.RowHeadersWidth = 51;
            dtgMantenimientos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dtgMantenimientos.Size = new Size(1000, 235);
            dtgMantenimientos.TabIndex = 1;
            // 
            // Equipo
            // 
            Equipo.DataPropertyName = "Equipo";
            Equipo.HeaderText = "Equipo";
            Equipo.MinimumWidth = 6;
            Equipo.Name = "Equipo";
            Equipo.ReadOnly = true;
            // 
            // TipoDeMantenimiento
            // 
            TipoDeMantenimiento.DataPropertyName = "Tipo";
            TipoDeMantenimiento.HeaderText = "Tipo de mantenimiento";
            TipoDeMantenimiento.MinimumWidth = 6;
            TipoDeMantenimiento.Name = "TipoDeMantenimiento";
            TipoDeMantenimiento.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "Fecha";
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Tecnico
            // 
            Tecnico.DataPropertyName = "Tecnico";
            Tecnico.HeaderText = "Tecnico Responsable";
            Tecnico.MinimumWidth = 6;
            Tecnico.Name = "Tecnico";
            Tecnico.ReadOnly = true;
            // 
            // Costo
            // 
            Costo.DataPropertyName = "Costo";
            Costo.HeaderText = "Costo";
            Costo.MinimumWidth = 6;
            Costo.Name = "Costo";
            Costo.ReadOnly = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(856, 302);
            btnSalir.Margin = new Padding(4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(118, 36);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Location = new Point(12, 288);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(107, 25);
            lblSuma.TabIndex = 3;
            lblSuma.Text = "Total : $0.00";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(12, 320);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(148, 25);
            lblPromedio.TabIndex = 4;
            lblPromedio.Text = "Promedio : $0.00";
            // 
            // lblFechaReciente
            // 
            lblFechaReciente.AutoSize = true;
            lblFechaReciente.Location = new Point(186, 288);
            lblFechaReciente.Name = "lblFechaReciente";
            lblFechaReciente.Size = new Size(144, 25);
            lblFechaReciente.TabIndex = 5;
            lblFechaReciente.Text = "Último: --/--/----";
            // 
            // lblTotalEquipo
            // 
            lblTotalEquipo.AutoSize = true;
            lblTotalEquipo.Location = new Point(186, 320);
            lblTotalEquipo.Name = "lblTotalEquipo";
            lblTotalEquipo.Size = new Size(165, 25);
            lblTotalEquipo.TabIndex = 6;
            lblTotalEquipo.Text = "Cant. por equipo: 0";
            // 
            // frmMantenimientos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1000, 354);
            Controls.Add(lblTotalEquipo);
            Controls.Add(lblFechaReciente);
            Controls.Add(lblPromedio);
            Controls.Add(lblSuma);
            Controls.Add(btnSalir);
            Controls.Add(dtgMantenimientos);
            Controls.Add(toolStrip1);
            Margin = new Padding(4);
            Name = "frmMantenimientos";
            Text = "Mantenimientos";
            Load += FrmMantenimientos_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMantenimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolBtnNuevoMantenimiento;
        private ToolStripButton toolBtnEditarMantenimiento;
        private ToolStripButton toolBtnEliminarMantenimiento;
        private DataGridView dtgMantenimientos;
        private Button btnSalir;
        private DataGridViewTextBoxColumn Equipo;
        private DataGridViewTextBoxColumn TipoDeMantenimiento;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Tecnico;
        private DataGridViewTextBoxColumn Costo;
        private Label lblSuma;
        private Label lblPromedio;
        private Label lblFechaReciente;
        private Label lblTotalEquipo;
    }
}

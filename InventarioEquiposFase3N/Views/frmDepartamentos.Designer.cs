namespace InventarioEquiposFase3N
{
    partial class frmDepartamentos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartamentos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            toolBtnNuevoDepartamento = new ToolStripButton();
            toolBtnEditarDepartamento = new ToolStripButton();
            toolBtnEliminarDepartamento = new ToolStripButton();
            dtgDepartamentos = new DataGridView();
            btnSalir = new Button();
            Codigo = new DataGridViewTextBoxColumn();
            clmUbicacion = new DataGridViewTextBoxColumn();
            clmEncargado = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDepartamentos).BeginInit();
            SuspendLayout();
            toolStrip1.BackColor = SystemColors.GradientActiveCaption;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolBtnNuevoDepartamento, toolBtnEditarDepartamento, toolBtnEliminarDepartamento });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(787, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            toolBtnNuevoDepartamento.Image = Properties.Resources.plus;
            toolBtnNuevoDepartamento.ImageTransparentColor = Color.Magenta;
            toolBtnNuevoDepartamento.Name = "toolBtnNuevoDepartamento";
            toolBtnNuevoDepartamento.Size = new Size(66, 24);
            toolBtnNuevoDepartamento.Tag = "";
            toolBtnNuevoDepartamento.Text = "Nuevo";
            toolBtnNuevoDepartamento.Click += toolBtnNuevoDepartamento_Click;
            toolBtnEditarDepartamento.Image = Properties.Resources.boton_editar;
            toolBtnEditarDepartamento.ImageTransparentColor = Color.Magenta;
            toolBtnEditarDepartamento.Name = "toolBtnEditarDepartamento";
            toolBtnEditarDepartamento.Size = new Size(61, 24);
            toolBtnEditarDepartamento.Text = "Editar";
            toolBtnEditarDepartamento.Click += toolBtnEditarDepartamento_Click;
            toolBtnEliminarDepartamento.Image = (Image)resources.GetObject("toolBtnEliminarDepartamento.Image");
            toolBtnEliminarDepartamento.ImageTransparentColor = Color.Magenta;
            toolBtnEliminarDepartamento.Name = "toolBtnEliminarDepartamento";
            toolBtnEliminarDepartamento.Size = new Size(74, 24);
            toolBtnEliminarDepartamento.Text = "Eliminar";
            toolBtnEliminarDepartamento.Click += btnEliminar_Click;
            dtgDepartamentos.AllowUserToAddRows = false;
            dtgDepartamentos.AllowUserToDeleteRows = false;
            dtgDepartamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDepartamentos.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(220, 232, 245);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgDepartamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgDepartamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDepartamentos.Columns.AddRange(new DataGridViewColumn[] { Codigo, clmUbicacion, clmEncargado, Nombre });
            dtgDepartamentos.EnableHeadersVisualStyles = false;
            dtgDepartamentos.Location = new Point(0, 20);
            dtgDepartamentos.Margin = new Padding(3, 2, 3, 2);
            dtgDepartamentos.Name = "dtgDepartamentos";
            dtgDepartamentos.ReadOnly = true;
            dtgDepartamentos.RowHeadersWidth = 51;
            dtgDepartamentos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dtgDepartamentos.Size = new Size(780, 146);
            dtgDepartamentos.TabIndex = 1;
            btnSalir.Location = new Point(668, 172);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(82, 22);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            Codigo.HeaderText = "Código";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            clmUbicacion.HeaderText = "Ubicacion";
            clmUbicacion.Name = "clmUbicacion";
            clmUbicacion.ReadOnly = true;
            clmEncargado.HeaderText = "Encargado";
            clmEncargado.Name = "clmEncargado";
            clmEncargado.ReadOnly = true;
            Nombre.HeaderText = "Departamento";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(787, 203);
            Controls.Add(btnSalir);
            Controls.Add(dtgDepartamentos);
            Controls.Add(toolStrip1);
            Location = new Point(0, 39);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmDepartamentos";
            Text = "Departamentos";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDepartamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolBtnNuevoDepartamento;
        private ToolStripButton toolBtnEditarDepartamento;
        private ToolStripButton toolBtnEliminarDepartamento;
        private DataGridView dtgDepartamentos;
        private Button btnSalir;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn clmUbicacion;
        private DataGridViewTextBoxColumn clmEncargado;
        private DataGridViewTextBoxColumn Nombre;
    }
}
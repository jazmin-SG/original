
namespace InventarioEquiposFase3N
{
    partial class frmConsultas
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            cmbEstado = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            dgvEquipos = new DataGridView();
            btnSalir = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            dtpFecha = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 0;
            label1.Text = "Código de equipo:";
            label1.Click += label1_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(151, 56);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(143, 27);
            txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 59);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 2;
            label2.Text = "Estado:";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(393, 56);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(213, 28);
            cmbEstado.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(634, 63);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 4;
            label3.Text = "Fecha de compra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(274, 9);
            label4.Name = "label4";
            label4.Size = new Size(230, 20);
            label4.TabIndex = 6;
            label4.Text = "Busqueda de equipos registrados";
            // 
            // dgvEquipos
            // 
            dgvEquipos.AllowUserToAddRows = false;
            dgvEquipos.AllowUserToDeleteRows = false;
            dgvEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEquipos.BackgroundColor = Color.White;
            dgvEquipos.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(220, 232, 245);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEquipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.EnableHeadersVisualStyles = false;
            dgvEquipos.Location = new Point(25, 150);
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.ReadOnly = true;
            dgvEquipos.RowHeadersWidth = 51;
            dgvEquipos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvEquipos.Size = new Size(958, 287);
            dgvEquipos.TabIndex = 7;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(889, 454);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Checked = false;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(778, 63);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.ShowCheckBox = true;
            dtpFecha.Size = new Size(205, 27);
            dtpFecha.TabIndex = 10;
            // 
            // frmConsultas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1027, 484);
            Controls.Add(dtpFecha);
            Controls.Add(btnSalir);
            Controls.Add(dgvEquipos);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbEstado);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Name = "frmConsultas";
            Text = "Consultas";
            Load += frmConsultas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodigo;
        private Label label2;
        private ComboBox cmbEstado;
        private Label label3;
        private Label label4;
        private DataGridView dgvEquipos;
        private Button btnSalir;
        private System.Windows.Forms.Timer timer1;
        private DateTimePicker dtpFecha;
    }
}

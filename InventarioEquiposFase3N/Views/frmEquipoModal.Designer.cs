
namespace InventarioEquiposFase3N
{
    partial class frmEquipoModal
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
            label1 = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtNumeroSerie = new TextBox();
            label5 = new Label();
            cmbTipoEquipo = new ComboBox();
            label6 = new Label();
            cmbEstado = new ComboBox();
            label7 = new Label();
            dtpFechaCompra = new DateTimePicker();
            label8 = new Label();
            nudAnioGarantia = new NumericUpDown();
            btnGuardar = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudAnioGarantia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(127, 9);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 1;
            txtCodigo.Validating += txtCodigo_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 42);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 76);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 3;
            label3.Text = "Modelo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 110);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 4;
            label4.Text = "Numero de serie";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(127, 42);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(125, 27);
            txtMarca.TabIndex = 5;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(127, 76);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(125, 27);
            txtModelo.TabIndex = 6;
            // 
            // txtNumeroSerie
            // 
            txtNumeroSerie.Location = new Point(129, 110);
            txtNumeroSerie.Name = "txtNumeroSerie";
            txtNumeroSerie.Size = new Size(125, 27);
            txtNumeroSerie.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 143);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 8;
            label5.Text = "Tipo de equipo";
            // 
            // cmbTipoEquipo
            // 
            cmbTipoEquipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoEquipo.FormattingEnabled = true;
            cmbTipoEquipo.Location = new Point(127, 143);
            cmbTipoEquipo.Name = "cmbTipoEquipo";
            cmbTipoEquipo.Size = new Size(151, 28);
            cmbTipoEquipo.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 177);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 10;
            label6.Text = "Estado";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(127, 177);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(151, 28);
            cmbEstado.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(-4, 211);
            label7.Name = "label7";
            label7.Size = new Size(123, 20);
            label7.TabIndex = 12;
            label7.Text = "Fecha de compra";
            // 
            // dtpFechaCompra
            // 
            dtpFechaCompra.Format = DateTimePickerFormat.Short;
            dtpFechaCompra.Location = new Point(127, 211);
            dtpFechaCompra.Name = "dtpFechaCompra";
            dtpFechaCompra.Size = new Size(250, 27);
            dtpFechaCompra.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 244);
            label8.Name = "label8";
            label8.Size = new Size(117, 20);
            label8.TabIndex = 14;
            label8.Text = "Año de Garantia";
            // 
            // nudAnioGarantia
            // 
            nudAnioGarantia.Location = new Point(129, 244);
            nudAnioGarantia.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudAnioGarantia.Name = "nudAnioGarantia";
            nudAnioGarantia.Size = new Size(150, 27);
            nudAnioGarantia.TabIndex = 15;
            nudAnioGarantia.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(25, 287);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(234, 287);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmEquipoModal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(432, 332);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(nudAnioGarantia);
            Controls.Add(label8);
            Controls.Add(dtpFechaCompra);
            Controls.Add(label7);
            Controls.Add(cmbEstado);
            Controls.Add(label6);
            Controls.Add(cmbTipoEquipo);
            Controls.Add(label5);
            Controls.Add(txtNumeroSerie);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEquipoModal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo Equipo";
            ((System.ComponentModel.ISupportInitialize)nudAnioGarantia).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodigo;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtNumeroSerie;
        private Label label5;
        private ComboBox cmbTipoEquipo;
        private Label label6;
        private ComboBox cmbEstado;
        private Label label7;
        private DateTimePicker dtpFechaCompra;
        private Label label8;
        private NumericUpDown nudAnioGarantia;
        private Button btnGuardar;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
    }
}

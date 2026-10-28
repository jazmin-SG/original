namespace InventarioEquiposFase3N
{
    partial class frmDepartamentoModal
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
            txtNombre = new TextBox();
            label2 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label3 = new Label();
            label4 = new Label();
            txtUbicacion = new TextBox();
            txtEncargado = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            label1.AutoSize = true;
            label1.Location = new Point(20, 7);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            txtCodigo.Location = new Point(89, 4);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(110, 23);
            txtCodigo.TabIndex = 1;
            txtNombre.Location = new Point(89, 37);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(110, 23);
            txtNombre.TabIndex = 2;
            label2.AutoSize = true;
            label2.Location = new Point(20, 40);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            btnGuardar.DialogResult = DialogResult.None;
            btnGuardar.Location = new Point(20, 185);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(138, 185);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            label3.AutoSize = true;
            label3.Location = new Point(20, 75);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 6;
            label3.Text = "Ubicacion";
            label4.AutoSize = true;
            label4.Location = new Point(20, 116);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 7;
            label4.Text = "Encargado";
            txtUbicacion.Location = new Point(89, 72);
            txtUbicacion.Margin = new Padding(3, 2, 3, 2);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(110, 23);
            txtUbicacion.TabIndex = 8;
            txtEncargado.Location = new Point(89, 113);
            txtEncargado.Margin = new Padding(3, 2, 3, 2);
            txtEncargado.Name = "txtEncargado";
            txtEncargado.Size = new Size(110, 23);
            txtEncargado.TabIndex = 9;
            errorProvider1.ContainerControl = this;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(490, 306);
            Controls.Add(txtEncargado);
            Controls.Add(txtUbicacion);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDepartamentoModal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo Departamento";
            Load += frmDepartamentoModal_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private Label label2;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label label3;
        private Label label4;
        private TextBox txtUbicacion;
        private TextBox txtEncargado;
        private ErrorProvider errorProvider1;
    }
}
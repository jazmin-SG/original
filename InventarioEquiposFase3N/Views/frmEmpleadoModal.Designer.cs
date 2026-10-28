
namespace InventarioEquiposFase3N
{
    partial class frmEmpleadoModal
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtCargo = new TextBox();
            label5 = new Label();
            cmbDepartamentos = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            btnAgregarFoto = new Button();
            mtxDUI = new MaskedTextBox();
            label3 = new Label();
            txtCorreo = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            label6 = new Label();
            txtApellido = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 16);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 0;
            label1.Text = "DUI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 49);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(115, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 27);
            txtNombre.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 115);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 6;
            label4.Text = "Cargo";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(115, 108);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(151, 27);
            txtCargo.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 149);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 8;
            label5.Text = "Departamento";
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Items.AddRange(new object[] { "Departamento 1", "Departamento 2", "Departamento 3" });
            cmbDepartamentos.Location = new Point(115, 141);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(151, 28);
            cmbDepartamentos.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(3, 215);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(157, 29);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(172, 215);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(137, 29);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(396, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 167);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btnAgregarFoto
            // 
            btnAgregarFoto.Location = new Point(396, 177);
            btnAgregarFoto.Name = "btnAgregarFoto";
            btnAgregarFoto.Size = new Size(190, 29);
            btnAgregarFoto.TabIndex = 8;
            btnAgregarFoto.Text = "Agregar Foto";
            btnAgregarFoto.UseVisualStyleBackColor = true;
            // 
            // mtxDUI
            // 
            mtxDUI.Location = new Point(115, 9);
            mtxDUI.Mask = "00000000-0";
            mtxDUI.Name = "mtxDUI";
            mtxDUI.Size = new Size(125, 27);
            mtxDUI.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 184);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 15;
            label3.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(115, 177);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(194, 27);
            txtCorreo.TabIndex = 5;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 80);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 17;
            label6.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(115, 75);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(151, 27);
            txtApellido.TabIndex = 2;
            // 
            // frmEmpleadoModal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(610, 272);
            Controls.Add(txtApellido);
            Controls.Add(label6);
            Controls.Add(txtCorreo);
            Controls.Add(label3);
            Controls.Add(mtxDUI);
            Controls.Add(btnAgregarFoto);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbDepartamentos);
            Controls.Add(label5);
            Controls.Add(txtCargo);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEmpleadoModal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo empleado";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtCargo;
        private Label label5;
        private ComboBox cmbDepartamentos;
        private Button btnGuardar;
        private Button btnCancelar;
        private PictureBox pictureBox1;
        private Button btnAgregarFoto;
        private MaskedTextBox mtxDUI;
        private Label label3;
        private TextBox txtCorreo;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
        private TextBox txtApellido;
        private Label label6;
    }
}

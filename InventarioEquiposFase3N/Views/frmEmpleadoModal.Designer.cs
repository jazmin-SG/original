
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
            picFoto = new PictureBox();
            btnAgregarFoto = new Button();
            mtxDUI = new MaskedTextBox();
            label3 = new Label();
            txtCorreo = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            label6 = new Label();
            txtApellido = new TextBox();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 38);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 0;
            label1.Text = "DUI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 71);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(135, 64);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 27);
            txtNombre.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 137);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 6;
            label4.Text = "Cargo";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(135, 130);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(151, 27);
            txtCargo.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 171);
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
            cmbDepartamentos.Location = new Point(135, 163);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(151, 28);
            cmbDepartamentos.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(9, 264);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(157, 29);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(199, 264);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(137, 29);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // picFoto
            // 
            picFoto.BackColor = SystemColors.ButtonHighlight;
            picFoto.Location = new Point(499, 4);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(213, 215);
            picFoto.SizeMode = PictureBoxSizeMode.AutoSize;
            picFoto.TabIndex = 12;
            picFoto.TabStop = false;
            // 
            // btnAgregarFoto
            // 
            btnAgregarFoto.Location = new Point(509, 225);
            btnAgregarFoto.Name = "btnAgregarFoto";
            btnAgregarFoto.Size = new Size(190, 29);
            btnAgregarFoto.TabIndex = 8;
            btnAgregarFoto.Text = "Agregar Foto";
            btnAgregarFoto.UseVisualStyleBackColor = true;
            btnAgregarFoto.Click += btnAgregarFoto_Click;
            // 
            // mtxDUI
            // 
            mtxDUI.Location = new Point(135, 31);
            mtxDUI.Mask = "00000000-0";
            mtxDUI.Name = "mtxDUI";
            mtxDUI.Size = new Size(125, 27);
            mtxDUI.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 206);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 15;
            label3.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(135, 199);
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
            label6.Location = new Point(38, 102);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 17;
            label6.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(135, 97);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(151, 27);
            txtApellido.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(509, 260);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(190, 29);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar Foto";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmEmpleadoModal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 341);
            Controls.Add(btnEliminar);
            Controls.Add(txtApellido);
            Controls.Add(label6);
            Controls.Add(txtCorreo);
            Controls.Add(label3);
            Controls.Add(mtxDUI);
            Controls.Add(btnAgregarFoto);
            Controls.Add(picFoto);
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
            Load += frmEmpleadoModal_Load;
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
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
        private PictureBox picFoto;
        private Button btnAgregarFoto;
        private MaskedTextBox mtxDUI;
        private Label label3;
        private TextBox txtCorreo;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
        private TextBox txtApellido;
        private Label label6;
        private Button btnEliminar;
    }
}

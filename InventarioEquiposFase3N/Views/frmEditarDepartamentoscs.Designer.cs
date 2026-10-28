
namespace InventarioEquiposFase3N
{
    partial class frmEditarDepartamentos
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
            label1 = new Label();
            label2 = new Label();
            cbxCodigo = new ComboBox();
            txtDepartamento = new TextBox();
            btnEditar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Location = new Point(40, 30);
            label1.Name = "label1";
            label1.Size = new Size(322, 20);
            label1.TabIndex = 0;
            label1.Text = "Seleccióne el código de departamento a editar";
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Location = new Point(40, 167);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 1;
            label2.Text = "Departamento:";
            //
            // cbxCodigo
            //
            cbxCodigo.FormattingEnabled = true;
            cbxCodigo.Location = new Point(115, 68);
            cbxCodigo.Name = "cbxCodigo";
            cbxCodigo.Size = new Size(151, 28);
            cbxCodigo.TabIndex = 2;
            //
            // txtDepartamento
            //
            txtDepartamento.Location = new Point(186, 164);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(125, 27);
            txtDepartamento.TabIndex = 3;
            //
            // btnEditar
            //
            btnEditar.Location = new Point(40, 261);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            //
            // btnCancelar
            //
            btnCancelar.Location = new Point(217, 252);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            //
            // frmEditarDepartamentos
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(404, 339);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(txtDepartamento);
            Controls.Add(cbxCodigo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEditarDepartamentos";
            Text = "frmEditarDepartamentoscs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbxCodigo;
        private TextBox txtDepartamento;
        private Button btnEditar;
        private Button btnCancelar;
    }
}

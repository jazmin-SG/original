
namespace InventarioEquiposFase3N
{
    partial class frmEditarMantenimiento
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
            comboBox1 = new ComboBox();
            btnBuscar = new Button();
            label2 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            btnGuardar = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            btnSalir = new Button();
            SuspendLayout();
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Location = new Point(29, 18);
            label1.Name = "label1";
            label1.Size = new Size(387, 20);
            label1.TabIndex = 0;
            label1.Text = "Seleccione el equipo en mantenimiento que desea editar";
            //
            // comboBox1
            //
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(114, 52);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(205, 28);
            comboBox1.TabIndex = 1;
            //
            // btnBuscar
            //
            btnBuscar.Location = new Point(168, 96);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Location = new Point(29, 150);
            label2.Name = "label2";
            label2.Size = new Size(168, 20);
            label2.TabIndex = 3;
            label2.Text = "Tipo de mantenimiento:";
            //
            // checkBox1
            //
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(218, 149);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "preventivo";
            checkBox1.UseVisualStyleBackColor = true;
            //
            // checkBox2
            //
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(325, 150);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(97, 24);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "correctivo";
            checkBox2.UseVisualStyleBackColor = true;
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Location = new Point(29, 195);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 6;
            label3.Text = "fecha:";
            //
            // dateTimePicker1
            //
            dateTimePicker1.Location = new Point(154, 188);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(289, 27);
            dateTimePicker1.TabIndex = 7;
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Location = new Point(29, 230);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 8;
            label4.Text = "Descripción:";
            //
            // label5
            //
            label5.AutoSize = true;
            label5.Location = new Point(29, 314);
            label5.Name = "label5";
            label5.Size = new Size(153, 20);
            label5.TabIndex = 9;
            label5.Text = "tecnico respponsable:";
            //
            // btnGuardar
            //
            btnGuardar.Location = new Point(40, 409);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            //
            // textBox1
            //
            textBox1.Location = new Point(154, 227);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 74);
            textBox1.TabIndex = 11;
            //
            // textBox2
            //
            textBox2.Location = new Point(194, 311);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 27);
            textBox2.TabIndex = 12;
            //
            // label6
            //
            label6.AutoSize = true;
            label6.Location = new Point(29, 357);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 13;
            label6.Text = "Costo:";
            //
            // textBox3
            //
            textBox3.Location = new Point(194, 350);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(249, 27);
            textBox3.TabIndex = 14;
            //
            // btnSalir
            //
            btnSalir.Location = new Point(303, 409);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            //
            // frmEditarMantenimiento
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(455, 450);
            Controls.Add(btnSalir);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "frmEditarMantenimiento";
            Text = "Editar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Button btnBuscar;
        private Label label2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private Button btnGuardar;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox3;
        private Button btnSalir;
    }
}

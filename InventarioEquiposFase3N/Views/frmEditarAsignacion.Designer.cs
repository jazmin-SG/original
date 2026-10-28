
namespace InventarioEquiposFase3N
{
    partial class frmEditarAsignacion
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbEquipo = new ComboBox();
            label6 = new Label();
            dtpFechaAsignacion = new DateTimePicker();
            dtpFechaDevolucion = new DateTimePicker();
            cmbEstado = new ComboBox();
            txtObservaciones = new TextBox();
            btnAceptar = new Button();
            btnSalir = new Button();
            label7 = new Label();
            cmbEmpleado = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 38);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Empleado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 132);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 2;
            label3.Text = "Fecha de Asignación";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 183);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 3;
            label4.Text = "Fecha de devolución";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 222);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 4;
            label5.Text = "Estado";
            // 
            // cmbEquipo
            // 
            cmbEquipo.FormattingEnabled = true;
            cmbEquipo.Location = new Point(105, 24);
            cmbEquipo.Name = "cmbEquipo";
            cmbEquipo.Size = new Size(151, 28);
            cmbEquipo.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 277);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 6;
            label6.Text = "Observaciones";
            // 
            // dtpFechaAsignacion
            // 
            dtpFechaAsignacion.Format = DateTimePickerFormat.Short;
            dtpFechaAsignacion.Location = new Point(180, 132);
            dtpFechaAsignacion.Name = "dtpFechaAsignacion";
            dtpFechaAsignacion.Size = new Size(250, 27);
            dtpFechaAsignacion.TabIndex = 7;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Format = DateTimePickerFormat.Short;
            dtpFechaDevolucion.Location = new Point(180, 183);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(250, 27);
            dtpFechaDevolucion.TabIndex = 8;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(180, 222);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(151, 28);
            cmbEstado.TabIndex = 9;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(180, 277);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(125, 27);
            txtObservaciones.TabIndex = 10;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(29, 395);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(453, 395);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 27);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 13;
            label7.Text = "Equipo";
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new Point(105, 74);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(151, 28);
            cmbEmpleado.TabIndex = 14;
            // 
            // frmEditarAsignacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 450);
            Controls.Add(cmbEmpleado);
            Controls.Add(label7);
            Controls.Add(btnSalir);
            Controls.Add(btnAceptar);
            Controls.Add(txtObservaciones);
            Controls.Add(cmbEstado);
            Controls.Add(dtpFechaDevolucion);
            Controls.Add(dtpFechaAsignacion);
            Controls.Add(label6);
            Controls.Add(cmbEquipo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEditarAsignacion";
            Text = "Editar Asignación";
            Load += frmEditarAsignacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbEquipo;
        private Label label6;
        private DateTimePicker dtpFechaAsignacion;
        private DateTimePicker dtpFechaDevolucion;
        private ComboBox cmbEstado;
        private TextBox txtObservaciones;
        private Button btnAceptar;
        private Button btnSalir;
        private Label label7;
        private ComboBox cmbEmpleado;
    }
}

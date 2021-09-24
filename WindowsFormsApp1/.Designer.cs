
namespace WindowsFormsApp1
{
    partial class Crear_Cuenta
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.opcion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.apellidos = new System.Windows.Forms.TextBox();
            this.correo = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(219, 34);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(166, 20);
            this.nombre.TabIndex = 1;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // opcion
            // 
            this.opcion.FormattingEnabled = true;
            this.opcion.Items.AddRange(new object[] {
            "Profesor",
            "Estudiante",
            "Acudiente"});
            this.opcion.Location = new System.Drawing.Point(302, 240);
            this.opcion.Name = "opcion";
            this.opcion.Size = new System.Drawing.Size(203, 21);
            this.opcion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Correo Electronico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellidos";
            // 
            // apellidos
            // 
            this.apellidos.Location = new System.Drawing.Point(408, 34);
            this.apellidos.Name = "apellidos";
            this.apellidos.Size = new System.Drawing.Size(166, 20);
            this.apellidos.TabIndex = 7;
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(219, 94);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(355, 20);
            this.correo.TabIndex = 8;
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(219, 156);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(355, 20);
            this.contraseña.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(219, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.Aqua;
            this.guardar.Location = new System.Drawing.Point(483, 298);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(91, 32);
            this.guardar.TabIndex = 11;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // fecha
            // 
            this.fecha.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.fecha.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fecha.Location = new System.Drawing.Point(219, 203);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(355, 20);
            this.fecha.TabIndex = 26;
            // 
            // Crear_Cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.apellidos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.opcion);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.Name = "Crear_Cuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.ComboBox opcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox apellidos;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.DateTimePicker fecha;
    }
}
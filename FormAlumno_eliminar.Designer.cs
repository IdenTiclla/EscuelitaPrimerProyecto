namespace SistemaEscuela
{
    partial class FormAlumno_eliminar
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
            this.lbAlumnos = new System.Windows.Forms.ListBox();
            this.Registrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Recuperar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAlumnos
            // 
            this.lbAlumnos.FormattingEnabled = true;
            this.lbAlumnos.Location = new System.Drawing.Point(47, 140);
            this.lbAlumnos.Name = "lbAlumnos";
            this.lbAlumnos.Size = new System.Drawing.Size(493, 264);
            this.lbAlumnos.TabIndex = 0;
            // 
            // Registrar
            // 
            this.Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registrar.Location = new System.Drawing.Point(164, 426);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(241, 40);
            this.Registrar.TabIndex = 9;
            this.Registrar.Text = "Eliminar";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(164, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Recuperar
            // 
            this.Recuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Recuperar.Location = new System.Drawing.Point(164, 73);
            this.Recuperar.Name = "Recuperar";
            this.Recuperar.Size = new System.Drawing.Size(241, 40);
            this.Recuperar.TabIndex = 13;
            this.Recuperar.Text = "Recuperar ultimo reigstro";
            this.Recuperar.UseVisualStyleBackColor = true;
            this.Recuperar.Click += new System.EventHandler(this.Recuperar_Click);
            // 
            // FormAlumno_eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 585);
            this.Controls.Add(this.Recuperar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.lbAlumnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAlumno_eliminar";
            this.Text = "FormAlumno_eliminar";
            this.Load += new System.EventHandler(this.FormAlumno_eliminar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAlumnos;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Recuperar;
    }
}
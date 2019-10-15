namespace SistemaEscuela
{
    partial class FormCurso
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
            this.Agregar_curso = new System.Windows.Forms.Button();
            this.nro_text = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.mostrar_curso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Agregar_curso
            // 
            this.Agregar_curso.Location = new System.Drawing.Point(191, 57);
            this.Agregar_curso.Name = "Agregar_curso";
            this.Agregar_curso.Size = new System.Drawing.Size(107, 23);
            this.Agregar_curso.TabIndex = 0;
            this.Agregar_curso.Text = "Agregar curso";
            this.Agregar_curso.UseVisualStyleBackColor = true;
            this.Agregar_curso.Click += new System.EventHandler(this.Agregar_curso_Click);
            // 
            // nro_text
            // 
            this.nro_text.Location = new System.Drawing.Point(342, 60);
            this.nro_text.Name = "nro_text";
            this.nro_text.Size = new System.Drawing.Size(100, 20);
            this.nro_text.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(342, 229);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            // 
            // mostrar_curso
            // 
            this.mostrar_curso.Location = new System.Drawing.Point(182, 229);
            this.mostrar_curso.Name = "mostrar_curso";
            this.mostrar_curso.Size = new System.Drawing.Size(75, 23);
            this.mostrar_curso.TabIndex = 3;
            this.mostrar_curso.Text = "mostrar";
            this.mostrar_curso.UseVisualStyleBackColor = true;
            this.mostrar_curso.Click += new System.EventHandler(this.mostrar_curso_Click);
            // 
            // FormCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mostrar_curso);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.nro_text);
            this.Controls.Add(this.Agregar_curso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCurso";
            this.Text = "FormCurso";
            this.Load += new System.EventHandler(this.FormCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Agregar_curso;
        private System.Windows.Forms.TextBox nro_text;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button mostrar_curso;
    }
}
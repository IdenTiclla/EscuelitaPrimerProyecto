namespace SistemaEscuela
{
    partial class FormProfesor_modificarr
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
            this.lbProfesor = new System.Windows.Forms.ListBox();
            this.edad_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sueldo_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.apellido_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbProfesor
            // 
            this.lbProfesor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProfesor.FormattingEnabled = true;
            this.lbProfesor.Location = new System.Drawing.Point(68, 243);
            this.lbProfesor.Name = "lbProfesor";
            this.lbProfesor.Size = new System.Drawing.Size(968, 277);
            this.lbProfesor.TabIndex = 8;
            this.lbProfesor.SelectedIndexChanged += new System.EventHandler(this.lbProfesor_SelectedIndexChanged);
            // 
            // edad_text
            // 
            this.edad_text.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edad_text.Location = new System.Drawing.Point(452, 165);
            this.edad_text.Name = "edad_text";
            this.edad_text.Size = new System.Drawing.Size(241, 37);
            this.edad_text.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(447, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 30);
            this.label4.TabIndex = 28;
            this.label4.Text = "Edad :";
            // 
            // sueldo_text
            // 
            this.sueldo_text.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sueldo_text.Location = new System.Drawing.Point(452, 63);
            this.sueldo_text.Name = "sueldo_text";
            this.sueldo_text.Size = new System.Drawing.Size(241, 37);
            this.sueldo_text.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 30);
            this.label3.TabIndex = 26;
            this.label3.Text = "Sueldo : ";
            // 
            // apellido_text
            // 
            this.apellido_text.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido_text.Location = new System.Drawing.Point(139, 165);
            this.apellido_text.Name = "apellido_text";
            this.apellido_text.Size = new System.Drawing.Size(241, 37);
            this.apellido_text.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "Apellido :";
            // 
            // nombre_text
            // 
            this.nombre_text.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_text.Location = new System.Drawing.Point(139, 74);
            this.nombre_text.Name = "nombre_text";
            this.nombre_text.Size = new System.Drawing.Size(241, 37);
            this.nombre_text.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre : ";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(497, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 40);
            this.button1.TabIndex = 33;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(139, 576);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(241, 40);
            this.btnModificar.TabIndex = 32;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // FormProfesor_modificarr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 687);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.edad_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sueldo_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.apellido_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbProfesor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProfesor_modificarr";
            this.Text = "FormProfesor_modificarr";
            this.Load += new System.EventHandler(this.FormProfesor_modificarr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProfesor;
        private System.Windows.Forms.TextBox edad_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sueldo_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox apellido_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnModificar;
    }
}
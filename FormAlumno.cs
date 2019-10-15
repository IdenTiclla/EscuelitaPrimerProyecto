using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SistemaEscuela
{
    public partial class FormAlumno : Form
    {
        Escuela escuela = new Escuela();
        public FormAlumno()
        {
            escuela = (Escuela)escuela.deserializar();
            InitializeComponent();
            
            foreach (Curso c in escuela.Cursos)
            {
                foreach (Estudiante es in c.Estudiantes)
                {
                    lbAlumnos.Items.Add(es);
                }
            }
            
            
        }
        

        private void FormAlumno_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            Form fh = new FormAlumno_insertar();
            fh.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            
            Form fh = new FormAlumno_Modificar();
            fh.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form fh = new FormAlumno_eliminar();
            fh.Show();
        }

        private void lbAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

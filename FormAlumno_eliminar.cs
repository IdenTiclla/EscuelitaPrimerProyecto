using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscuela
{
    
    public partial class FormAlumno_eliminar : Form
    {
        Escuela escuela = new Escuela();
        Stack<Estudiante> mipila = new Stack<Estudiante>();
        public FormAlumno_eliminar()
        {
            //escuela = (Escuela)escuela.deserializar();
            
            InitializeComponent();
            foreach (Curso c in escuela.Cursos)
            {
                foreach (Estudiante es in c.Estudiantes)
                {
                    lbAlumnos.Items.Add(es);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            /*
            Estudiante es = (Estudiante)lbAlumnos.SelectedItem;
            if (MessageBox.Show($"Esta seguro que desea eliminar el {es}", "MessageBox Title", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                foreach (Curso c in escuela.Cursos)
                {

                    c.remove_student(es);
                    mipila.Push(es);
                    
                        
                }
                escuela.serealizar();

            }
            */
        }

        private void FormAlumno_eliminar_Load(object sender, EventArgs e)
        {

        }

        private void Recuperar_Click(object sender, EventArgs e)
        {
        }
    }
}

using System;
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
    public partial class FormAlumno_Modificar : Form
    {
        Escuela escuela = new Escuela();
        public FormAlumno_Modificar()
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

                cbGenero.Items.Add("Masculino");
                cbGenero.Items.Add("Femenino");

                


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void FormAlumno_Modificar_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            Estudiante est = (Estudiante)lbAlumnos.SelectedItem;

            est.Nombre = txtnombre.Text;
            est.Apellido = txtapellido.Text;
            est.Tutor = txtTutor.Text;
            est.Fechanac = date_nac.Value;

            escuela.serealizar();

        }

        private void lbAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Estudiante est = (Estudiante)lbAlumnos.SelectedItem;
            txtnombre.Text = est.Nombre;
            txtapellido.Text = est.Apellido;
            txtTutor.Text = est.Tutor;
            date_nac.Value = est.Fechanac;
        }
    }
}

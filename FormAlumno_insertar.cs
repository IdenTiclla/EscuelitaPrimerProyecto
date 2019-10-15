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
    public partial class FormAlumno_insertar : Form
    {
        Escuela escuela = new Escuela();
        public FormAlumno_insertar()
        {
           escuela = (Escuela)escuela.deserializar();
            InitializeComponent();
            cbGenero.Items.Add("Masculino");
            cbGenero.Items.Add("Femenino");

            foreach (Curso c in escuela.Cursos)
            {
                cbCurso.Items.Add(c);
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string apellido = txtapellido.Text;
            Curso c = (Curso)cbCurso.SelectedItem;
            string tutor = txtTutor.Text;
            string genero = (string)cbGenero.SelectedItem;
            DateTime f_nac = date_nac.Value;
            Estudiante es = new Estudiante(nombre, apellido, tutor, genero, f_nac);
            c.Estudiantes.AddLast(es);
            escuela.serealizar();
            MessageBox.Show($"{es}");
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAlumno_insertar_Load(object sender, EventArgs e)
        {

        }
    }
}

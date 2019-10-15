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
    public partial class FormProfesor_insertar : Form
    {
        Escuela escuela = new Escuela();
        public FormProfesor_insertar()
        {
            escuela = (Escuela)escuela.deserializar();
            
            InitializeComponent();
            foreach (Curso c in escuela.Cursos)
            {
                cbCurso.Items.Add(c);
            }
        }

        private void FormProfesor_insertar_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            string nombre = nombre_text.Text;
            string apellido = apellido_text.Text;
            double sueldo = Double.Parse(sueldo_text.Text);
            int edad = int.Parse(edad_text.Text);
            Profesor p = new Profesor(nombre,apellido,sueldo,edad);

            Curso c = (Curso)cbCurso.SelectedItem;
            c.Profesor = p;

            escuela.serealizar();
        }
    }
}

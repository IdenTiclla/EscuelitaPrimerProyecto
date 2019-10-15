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
    public partial class FormProfesor : Form
    {
        Escuela escuela = new Escuela();
        public FormProfesor()
        {
            escuela = (Escuela)escuela.deserializar();
            InitializeComponent();
            foreach (Curso c in escuela.Cursos)
            {
                if(c.Profesor != null)
                {
                    lbProfesor.Items.Add(c.Profesor);
                }
                   
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form fh = new FormProfesor_insertar();
            fh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fh = new FormProfesor_modificarr();
            fh.Show();
        }

        private void FormProfesor_Load(object sender, EventArgs e)
        {

        }

        private void lbProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

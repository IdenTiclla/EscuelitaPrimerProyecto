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
    public partial class FormMateria : Form
    {
        Escuela escuela = new Escuela();
        public FormMateria()
        {
            InitializeComponent();
            escuela = (Escuela)escuela.deserializar();
            foreach (Curso c in escuela.Cursos)
            {
                if (c.Materia != null)
                {
                    lbMateria.Items.Add(c.Materia);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fh = new FormMateria_insertar();
            fh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fh = new FormMateria_modificar();
            fh.Show();
        }

        private void FormMateria_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

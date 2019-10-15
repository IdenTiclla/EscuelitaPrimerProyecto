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
    public partial class FormMateria_insertar : Form
    {
        Escuela escuela = new Escuela();
        public FormMateria_insertar()
        {
            escuela = (Escuela)escuela.deserializar();
            InitializeComponent();
            cbTurno.Items.Add("maniana");
            cbTurno.Items.Add("Tarde");

            foreach (Curso c in escuela.Cursos)
            {
                cbCurso.Items.Add(c);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string turno = (string)cbTurno.SelectedItem;
            Materia m = new Materia(nombre,turno);
            Curso c = (Curso)cbCurso.SelectedItem;
            c.Materia = m;
            escuela.serealizar();
            MessageBox.Show($"{m}");
        }

        private void FormMateria_insertar_Load(object sender, EventArgs e)
        {

        }
    }
}

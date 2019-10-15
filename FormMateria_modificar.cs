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
    public partial class FormMateria_modificar : Form
    {
        Escuela escuela = new Escuela();
        public FormMateria_modificar()
        {
            InitializeComponent();
            cbTurno.Items.Add("maniana");
            cbTurno.Items.Add("tarde");
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
            this.Close();
        }

        private void FormMateria_modificar_Load(object sender, EventArgs e)
        {

        }

        private void lbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Materia m = (Materia)lbMateria.SelectedItem;
            txtNombre.Text = m.Nombre;
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            Materia m = (Materia)lbMateria.SelectedItem;
            m.Nombre = txtNombre.Text;
            m.Turno = (string)cbTurno.SelectedItem;

            escuela.serealizar();
        }
    }
}

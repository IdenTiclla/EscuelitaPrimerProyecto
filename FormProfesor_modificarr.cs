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
    public partial class FormProfesor_modificarr : Form
    {
        Escuela escuela = new Escuela();
        public FormProfesor_modificarr()
        {
            escuela = (Escuela)escuela.deserializar();
            InitializeComponent();
            foreach (Curso c in escuela.Cursos)
            {
                if (c.Profesor != null)
                {
                    lbProfesor.Items.Add(c.Profesor);
                }

            }
        }

        private void FormProfesor_modificarr_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Profesor prof = (Profesor)lbProfesor.SelectedItem;
            nombre_text.Text = prof.Nombre;
            apellido_text.Text = prof.Apellido;
            sueldo_text.Text = prof.Sueldo.ToString();
            edad_text.Text = prof.Edad.ToString();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            Profesor prof = (Profesor)lbProfesor.SelectedItem;
            prof.Nombre = nombre_text.Text;
            prof.Apellido = apellido_text.Text;
            prof.Sueldo = double.Parse(sueldo_text.Text);
            prof.Edad = int.Parse(edad_text.Text);

            escuela.serealizar();

        }
    }
}

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
    public partial class FormCurso : Form
    {
        Escuela escuela = new Escuela();
        public FormCurso()
        {
            escuela = (Escuela)escuela.deserializar();
            InitializeComponent();
        }

        private void Agregar_curso_Click(object sender, EventArgs e)
        {
            int nro = int.Parse(nro_text.Text);
            Curso c = new Curso(nro);
            if (!escuela.Cursos.Contains(c))
            {
                escuela.addCurso(c);
                escuela.serealizar();
                listBox1.Items.Add($"Curso: {c}");
                nro_text.Clear();
            }
            else
            {
                MessageBox.Show("Ya se registro el curso!");
            }

        }

        private void mostrar_curso_Click(object sender, EventArgs e)
        {
            
            foreach (Curso c in escuela.Cursos)
            {
                MessageBox.Show($"{c}");
            }
        }

        private void FormCurso_Load(object sender, EventArgs e)
        {

        }
    }
}

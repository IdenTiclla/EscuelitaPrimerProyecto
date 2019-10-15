using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SistemaEscuela
{
    public partial class Form1 : Form
    {
        Escuela mi_escuela;

        public Form1()
        {
            mi_escuela = new Escuela();
            

            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wmsg, int wparam, int lparam);

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if(panelHorizontal.Width == 250)
            {
                panelHorizontal.Width = 80;
            }
            else
            {
                panelHorizontal.Width = 250;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestore.Visible = true;
            btnMaximize.Visible = false;
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestore.Visible = false;
            btnMaximize.Visible = true;
        }

        private void PanelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void AbrirFormPanel(object Formhijo)
        {
            if (this.panelControlador.Controls.Count > 0)
            {
                this.panelControlador.Controls.RemoveAt(0);
            }
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelControlador.Controls.Add(fh);
            this.panelControlador.Tag = fh;
            fh.Show();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormAlumno());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormProfesor());
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormMateria());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormCurso());
        }
    }
}

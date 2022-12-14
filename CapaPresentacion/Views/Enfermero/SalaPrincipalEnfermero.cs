using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Views.Enfermero;

namespace CapaPresentacion.Views.Paciente
{
    public partial class SalaPrincipalEnfermero : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public SalaPrincipalEnfermero()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Medicamentos medicina = new Medicamentos();
            medicina.Show();
            this.Close();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            InicioSesion inicio = new InicioSesion();
            inicio.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Pacientes paciente = new Pacientes();
            paciente.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ConsultaEnfermero enfermero = new ConsultaEnfermero();
            enfermero.Show();
            this.Close();
        }

        private void SalaPrincipalEnfermero_Load(object sender, EventArgs e)
        {

        }
    }
}

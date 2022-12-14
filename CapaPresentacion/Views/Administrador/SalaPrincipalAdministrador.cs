using CapaPresentacion.Views.Medico;
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

namespace CapaPresentacion.Views.Administrador
{
    public partial class SalaPrincipalAdministrador : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public SalaPrincipalAdministrador()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Medicamentos medicamento = new Medicamentos();
            medicamento.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Médico medico = new Médico();
            medico.Show();
            this.Close();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            InicioSesion usuario = new InicioSesion();
            usuario.Show();
            this.Close();
        }

        private void SalaPrincipalAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Enfermero enfermero = new Enfermero();
            enfermero.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MostrarDiagnosticos diag = new MostrarDiagnosticos();
            diag.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PacientesRegistrados pacientes = new PacientesRegistrados();
            pacientes.Show();
            this.Close();
        }
    }
}

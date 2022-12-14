using CapaNegocio;
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
    public partial class PacientesRegistrados : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public PacientesRegistrados()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void MostrarPacientes()
        {
            CN_Paciente objeto = new CN_Paciente();
            dgvPacientes.DataSource = objeto.MostrarPacientes();
        }

        private void PacientesRegistrados_Load(object sender, EventArgs e)
        {
            MostrarPacientes();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            SalaPrincipalAdministrador admin = new SalaPrincipalAdministrador();
            admin.Show();
            this.Close();
        }
    }
}

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

namespace CapaPresentacion.Views.Medico
{
    public partial class MostrarDiagnosticos : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public MostrarDiagnosticos()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        CN_ConsultasMedico objetoMedico = new CN_ConsultasMedico();


        private void Diagnosticos()
        {
            CN_ConsultasMedico objeto = new CN_ConsultasMedico();
            dgvDiagnostico.DataSource = objeto.MostrarConsultasMedico();
        }

        private void MostrarGiagnosticos_Load(object sender, EventArgs e)
        {
            Diagnosticos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            InicioSesion sesion = new InicioSesion();
            sesion.Show();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Views.Medico
{
    public partial class SalaPrincipalMedico : Form
    {
        public SalaPrincipalMedico()
        {
            InitializeComponent();
        }

        private void SalaPrincipalMedico_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Consultas consulta = new Consultas();
            consulta.Show();
            this.Close();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            InicioSesion sesion = new InicioSesion();
            sesion.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MostrarDiagnosticos diagnosticos = new MostrarDiagnosticos();
            diagnosticos.Show();
            this.Close();
        }
    }
}

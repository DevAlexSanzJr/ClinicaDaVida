using CapaPresentacion.Middlewares;
using CapaPresentacion.Models;
using CapaPresentacion.Views;
using CapaPresentacion.Views.Administrador;
using CapaPresentacion.Views.Medico;
using CapaPresentacion.Views.Paciente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class InicioSesion : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public InicioSesion()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        // Login Method
        public void IniciarSesion()
        {
            try
            {
                if (cbInicioSesión.Text == "Administrador")
                {
                    using (Models.ClinicaMedica_DaVida db = new Models.ClinicaMedica_DaVida())
                    {
                        if (txtCodigo.Text != "" && txtPass.Text != "")
                        {
                            string encryptPass = Encrypt.GetSHA256(txtPass.Text.Trim());

                            var data = from d in db.Administrador
                                       where d.nombreUsuario == txtCodigo.Text
                                       && d.password == encryptPass
                                       select d;

                            if (data.Count() > 0)
                            {
                                SalaPrincipalAdministrador sala = new SalaPrincipalAdministrador();
                                ClearFields();
                                sala.Show();
                                this.Hide();
                            }
                            else
                            {
                                ClearFields();
                                MessageBox.Show("El usuario 'Administrador' no Existe en la base de datos!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No pueden estar los campos vacíos!");
                        }
                    }
                }
                else
                    if (cbInicioSesión.Text == "Médico")
                {
                    using (Models.ClinicaMedica_DaVida db = new Models.ClinicaMedica_DaVida())
                    {
                        if (txtCodigo.Text != "" && txtPass.Text != "")
                        {
                            string encryptPass = Encrypt.GetSHA256(txtPass.Text.Trim());

                            var data = from d in db.Medicos
                                       where d.codigo == txtCodigo.Text
                                       && d.contraMedico == encryptPass
                                       select d;

                            if (data.Count() > 0)
                            {
                                SalaPrincipalMedico sala = new SalaPrincipalMedico();
                                ClearFields();
                                sala.Show();
                                this.Hide();
                            }
                            else
                            {
                                ClearFields();
                                MessageBox.Show("El usuario 'Medico' no Existe!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No pueden estar los campos vacíos!");
                        }
                    }
                }
                else
                    if (cbInicioSesión.Text == "Enfermero")
                {
                    using (Models.ClinicaMedica_DaVida db = new Models.ClinicaMedica_DaVida())
                    {
                        string encryptPass = Encrypt.GetSHA256(txtPass.Text.Trim());

                        if (txtCodigo.Text != "" && txtPass.Text != "")
                        {
                            var data = from d in db.Enfermeros
                                       where d.codigo == txtCodigo.Text
                                       && d.contraEnfermero == encryptPass
                                       select d;

                            if (data.Count() > 0)
                            {
                                SalaPrincipalEnfermero sala = new SalaPrincipalEnfermero();
                                ClearFields();
                                sala.Show();
                                this.Hide();
                            }
                            else
                            {
                                ClearFields();
                                MessageBox.Show("El usuario 'Enfermero' no Existe!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No pueden estar los campos vacíos!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No puede estar vacío el campo del perfil o no puede haber otro valor", "Campo Vacío o Otro valor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void ClearFields()
        {
            txtCodigo.Clear();
            txtPass.Clear();
            cbInicioSesión.Text = "";
        }

        private void InicioSesión_Load(object sender, EventArgs e)
        {

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void pbHide_Click(object sender, EventArgs e)
        {
            pbShow.BringToFront();
            txtPass.PasswordChar = '*';
        }

        private void pbShow_Click(object sender, EventArgs e)
        {
            pbHide.BringToFront();
            txtPass.PasswordChar = '\0';
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void lblForgetPass_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}

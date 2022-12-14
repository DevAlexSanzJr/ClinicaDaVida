using CapaNegocio;
using CapaPresentacion.Views.Paciente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Views.Enfermero
{
    public partial class ConsultaEnfermero : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public ConsultaEnfermero()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public class ConexionDB
        {
            private SqlConnection Conexion = new SqlConnection("Server=DEVALEXSANZ\\SQLEXPRESS;DataBase=ClinicaMedica_DaVida;Integrated Security=SSPI");

            public SqlConnection AbrirConexion()
            {
                if (Conexion.State == ConnectionState.Closed)
                    Conexion.Open();
                return Conexion;
            }

            public SqlConnection CerrarConexion()
            {
                if (Conexion.State == ConnectionState.Open)
                    Conexion.Close();
                return Conexion;
            }
        }

        ConexionDB cn = new ConexionDB();

        public DataTable CargarComboMedico()
        {
            SqlDataAdapter da = new SqlDataAdapter("CargarMedicos", cn.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable CargarComboPaciente()
        {
            SqlDataAdapter da = new SqlDataAdapter("CargarPacientes", cn.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        CN_ConsultasEnfermero objetoCN = new CN_ConsultasEnfermero();
        private string idConsultaEnfermero = null;
        private bool Editar = false;

        private void MostrarConsultasEnfermero()
        {
            CN_ConsultasEnfermero objeto = new CN_ConsultasEnfermero();
            dgvConsultaEnfermero.DataSource = objeto.MostrarConsultasEnfermero();
        }

        private void MostrarMedicosEnfermero()
        {
            CN_ConsultasEnfermero objeto = new CN_ConsultasEnfermero();
            dgvMostrarMedicos.DataSource = objeto.MostrarMedicosEnfermero();
        }
        
        private void GuardarConsultaEnfermero()
        {
            try
            {
                if (cbPaciente.Text != "" && cbMedico.Text != "" && txtDesc.Text != "")
                {
                    if (Editar == false)
                    {
                        try
                        {
                            objetoCN.CrearConsultasEnfermero(cbPaciente.Text, cbMedico.Text, txtDesc.Text);
                            MessageBox.Show("Su Consulta se creó correctamente!", "Consulta Creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarConsultasEnfermero();
                            LimpiarCampos();
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show($"No se pudo crear la consulta: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            LimpiarCampos();
                        }
                    }
                    if (Editar == true)
                    {
                        try
                        {
                            objetoCN.EditarConsultasEnfermero(cbPaciente.Text, cbMedico.Text, txtDesc.Text, idConsultaEnfermero);
                            MessageBox.Show("La consulta se editó correctamente", "Editado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                            MostrarConsultasEnfermero();
                            Editar = false;
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show($"No se pudo editar el registro de la consulta: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            LimpiarCampos();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Faltan ingresar algunos datos", "Advertencia: Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Se produjo el siguiente error: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarConsultaEnfermero()
        {
            try
            {
                if (dgvConsultaEnfermero.SelectedRows.Count > 0)
                {
                    Editar = true;
                    cbPaciente.Text = dgvConsultaEnfermero.CurrentRow.Cells["nombrePaciente"].Value.ToString();
                    cbMedico.Text = dgvConsultaEnfermero.CurrentRow.Cells["nombreMedico"].Value.ToString();
                    txtDesc.Text = dgvConsultaEnfermero.CurrentRow.Cells["descripcion"].Value.ToString();
                    idConsultaEnfermero = dgvConsultaEnfermero.CurrentRow.Cells["id"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Seleccione una fila por favor", "Ítem no Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Se produjo el siguiente error: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarConsultaEnfermero()
        {
            try
            {
                if (dgvConsultaEnfermero.SelectedRows.Count > 0)
                {
                    idConsultaEnfermero = dgvConsultaEnfermero.CurrentRow.Cells["id"].Value.ToString();
                    objetoCN.EliminarConsultasEnfermero(idConsultaEnfermero);
                    MessageBox.Show("Registro de consulta eliminado correctamente!", "Consulta Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarConsultasEnfermero();
                }
                else
                {
                    MessageBox.Show("seleccione una fila por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Se produjo el siguiente error: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultaEnfermero_Load(object sender, EventArgs e)
        {
            MostrarConsultasEnfermero();
            MostrarMedicosEnfermero();
            cbMedico.DataSource = CargarComboMedico();
            cbMedico.DisplayMember = "nombre";

            cbPaciente.DataSource = CargarComboPaciente();
            cbPaciente.DisplayMember = "nombre";
        }
        
        public void LimpiarCampos()
        {
            cbPaciente.Text = "";
            cbMedico.Text = "";
            txtDesc.Text = "";
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarConsultaEnfermero();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            SalaPrincipalEnfermero enfermero = new SalaPrincipalEnfermero();
            enfermero.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarConsultaEnfermero();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarConsultaEnfermero();
        }

        private void cbPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras y espacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void cbMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras y espacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
    }
}

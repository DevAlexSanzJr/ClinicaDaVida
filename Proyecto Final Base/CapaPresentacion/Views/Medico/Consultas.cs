using CapaNegocio;
using CapaPresentacion.Views.Enfermero;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Views.Medico
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
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
            SqlDataAdapter da = new SqlDataAdapter("CargarMedicamentos", cn.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private string idConsulta = null;
        CN_ConsultasEnfermero objetoCN = new CN_ConsultasEnfermero();
        
        private void MostrarConsultas()
        {
            CN_ConsultasEnfermero objetoConsultasEnfermero = new CN_ConsultasEnfermero();
            dgvConsultasEnfermero.DataSource = objetoConsultasEnfermero.MostrarConsultasEnfermero();
        }

        private void TraerDatos()
        {
            try
            {
                if (dgvConsultasEnfermero.SelectedRows.Count > 0)
                {
                    txtPaciente.Text = dgvConsultasEnfermero.CurrentRow.Cells["nombrePaciente"].Value.ToString();
                    txtMedico.Text = dgvConsultasEnfermero.CurrentRow.Cells["nombreMedico"].Value.ToString();
                    txtDesc.Text = dgvConsultasEnfermero.CurrentRow.Cells["descripcion"].Value.ToString();
                    idConsulta = dgvConsultasEnfermero.CurrentRow.Cells["id"].Value.ToString();
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



        CN_ConsultasMedico objetoMedico = new CN_ConsultasMedico();
        private string idDiagnostico = null;
        private bool Editar = false;


        private void MostrarConsultaMedico()
        {
            CN_ConsultasMedico objeto = new CN_ConsultasMedico();
            dgvConsultas.DataSource = objeto.MostrarConsultasMedico();
        }

        private void GuardarConsultaMedico()
        {
            try
            {
                if (txtPaciente.Text != "" && txtMedico.Text != "" && txtDesc.Text != "" && txtDiagnostico.Text != "" && cbMedicamentoUno.Text != "" && cbMedicamentoDos.Text != "" && cbMedicamentoTres.Text != "" && cbMedicamentoCuatro.Text != "")
                {
                    if (Editar == false)
                    {
                        try
                        {
                            objetoMedico.CrearConsultasMedico(txtPaciente.Text, txtMedico.Text, txtDesc.Text, txtDiagnostico.Text, cbMedicamentoUno.Text, cbMedicamentoDos.Text, cbMedicamentoTres.Text, cbMedicamentoCuatro.Text);
                            MessageBox.Show("Su Consulta se creó correctamente!", "Consulta Creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarConsultaMedico();
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show($"No se pudo crear la consulta: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (Editar == true)
                    {
                        try
                        {
                            objetoMedico.EditarConsultasMedico(txtPaciente.Text, txtMedico.Text, txtDesc.Text, txtDiagnostico.Text, cbMedicamentoUno.Text, cbMedicamentoDos.Text, cbMedicamentoTres.Text, cbMedicamentoCuatro.Text, idDiagnostico);
                            MessageBox.Show("La consulta se editó correctamente", "Editado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarConsultaMedico();
                            Editar = false;
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show($"No se pudo editar el registro de la consulta: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ActualizarConsultaMedico()
        {
            try
            {
                if (dgvConsultas.SelectedRows.Count > 0)
                {
                    Editar = true;
                    txtPaciente.Text = dgvConsultas.CurrentRow.Cells["nombrePaciente"].Value.ToString();
                    txtMedico.Text = dgvConsultas.CurrentRow.Cells["nombreMedico"].Value.ToString();
                    txtDesc.Text = dgvConsultas.CurrentRow.Cells["descripcion"].Value.ToString();
                    txtDiagnostico.Text = dgvConsultas.CurrentRow.Cells["diagnostico"].Value.ToString();
                    cbMedicamentoUno.Text = dgvConsultas.CurrentRow.Cells["medicamento_Uno"].Value.ToString();
                    cbMedicamentoDos.Text = dgvConsultas.CurrentRow.Cells["medicamento_Dos"].Value.ToString();
                    cbMedicamentoTres.Text = dgvConsultas.CurrentRow.Cells["medicamento_Tres"].Value.ToString();
                    cbMedicamentoCuatro.Text = dgvConsultas.CurrentRow.Cells["medicamento_Cuatro"].Value.ToString();
                    idDiagnostico = dgvConsultas.CurrentRow.Cells["id"].Value.ToString();
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

        private void EliminarConsultaMedico()
        {
            try
            {
                if (dgvConsultas.SelectedRows.Count > 0)
                {
                    idDiagnostico = dgvConsultas.CurrentRow.Cells["id"].Value.ToString();
                    objetoMedico.EliminarConsultasMedico(idDiagnostico);
                    MessageBox.Show("Registro de consulta eliminado correctamente!", "Consulta Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarConsultaMedico();
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

        private void Consultas_Load(object sender, EventArgs e)
        {
            MostrarConsultaMedico();
            MostrarConsultas();
            cbMedicamentoUno.DataSource = CargarComboMedico();
            cbMedicamentoUno.DisplayMember = "nombre";

            cbMedicamentoDos.DataSource = CargarComboMedico();
            cbMedicamentoDos.DisplayMember = "nombre";

            cbMedicamentoTres.DataSource = CargarComboMedico();
            cbMedicamentoTres.DisplayMember = "nombre";

            cbMedicamentoCuatro.DataSource = CargarComboMedico();
            cbMedicamentoCuatro.DisplayMember = "nombre";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMedico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTraerDatos_Click(object sender, EventArgs e)
        {
            TraerDatos();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            SalaPrincipalMedico medico = new SalaPrincipalMedico();
            medico.Show();
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarConsultaMedico();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarConsultaMedico();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarConsultaMedico();
        }
    }
}

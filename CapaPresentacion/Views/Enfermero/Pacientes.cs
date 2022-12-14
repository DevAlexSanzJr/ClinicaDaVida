using CapaNegocio;
using CapaPresentacion.Views.Paciente;
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

namespace CapaPresentacion.Views.Enfermero
{
    public partial class Pacientes : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public Pacientes()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        CN_Paciente objetoCN = new CN_Paciente();
        private string idPaciente = null;
        private bool Editar = false;

        private void MostrarPacientes()
        {
            CN_Paciente objeto = new CN_Paciente();
            dgvPacientes.DataSource = objeto.MostrarPacientes();
        }

        private void GuardarPacientes()
        {
            try
            {
                if (txtNombre.Text != "" && txtEdad.Text != "" && cbGenero.Text != "" && txtCodigo.Text != "")
                {
                    if (Editar == false)
                    {
                        try
                        {
                            objetoCN.CrearPaciente(txtNombre.Text, Convert.ToInt32(txtEdad.Text), txtEstatura.Text, txtPeso.Text, cbGenero.Text, txtCodigo.Text);
                            MessageBox.Show("Paciente se creó correctamente!", "Paciente Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarPacientes();
                            limpiarCampos();
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show($"No se pudo crear el registro del Paciente: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (Editar == true)
                    {
                        try
                        {
                            objetoCN.EditarPaciente(txtNombre.Text, txtEdad.Text, txtEstatura.Text, txtPeso.Text, cbGenero.Text, txtCodigo.Text, idPaciente);
                            MessageBox.Show("Paciente se editó correctamente", "Editado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarPacientes();
                            limpiarCampos();
                            Editar = false;
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show($"No se pudo editar el registro del Paciente: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ActualizarPaciente()
        {
            try
            {
                if (dgvPacientes.SelectedRows.Count > 0)
                {
                    Editar = true;
                    txtNombre.Text = dgvPacientes.CurrentRow.Cells["nombre"].Value.ToString();
                    txtEdad.Text = dgvPacientes.CurrentRow.Cells["edad"].Value.ToString();
                    txtEstatura.Text = dgvPacientes.CurrentRow.Cells["estatura"].Value.ToString();
                    txtPeso.Text = dgvPacientes.CurrentRow.Cells["peso"].Value.ToString();
                    cbGenero.Text = dgvPacientes.CurrentRow.Cells["genero"].Value.ToString();
                    txtCodigo.Text = dgvPacientes.CurrentRow.Cells["codigo"].Value.ToString();
                    idPaciente = dgvPacientes.CurrentRow.Cells["id"].Value.ToString();
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

        private void EliminarPaciente()
        {
            try
            {
                if (dgvPacientes.SelectedRows.Count > 0)
                {
                    idPaciente = dgvPacientes.CurrentRow.Cells["id"].Value.ToString();
                    objetoCN.EliminarPaciente(idPaciente);
                    MessageBox.Show("Paciente eliminado correctamente!", "Paciente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarPacientes();
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

        private void limpiarCampos()
        {
            cbGenero.Text = "";
            txtEdad.Clear();
            txtNombre.Clear();
        }

        private void Paciente_Load(object sender, EventArgs e)
        {
            MostrarPacientes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarPacientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarPaciente();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarPaciente();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            SalaPrincipalEnfermero enfermero = new SalaPrincipalEnfermero();
            enfermero.Show();
            this.Close();
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != char.Parse("-")))
            {
                MessageBox.Show("Solo se permiten letras y guiones", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != char.Parse(" ")))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void cbGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras y espacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtEstatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

using CapaNegocio;
using CapaPresentacion.Middlewares;
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
    public partial class Médico : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public Médico()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        CN_Medico objetoCN = new CN_Medico();
        private string idMedico = null;
        private bool Editar = false;

        private void MostrarMedicos()
        {
            CN_Medico objeto = new CN_Medico();
            dgvMedicos.DataSource = objeto.MostrarMedicos();
        }

        private void GuardarMedico()
        {
            try
            {
                if (txtNombre.Text != "" && txtEdad.Text != "" && cbGenero.Text != "" && cbEspecialidad.Text != "" && txtCodigo.Text != "" && txtContra.Text != "")
                {
                    if (Editar == false)
                    {
                        try
                        {
                            objetoCN.CrearMedico(txtNombre.Text, Convert.ToInt32(txtEdad.Text),cbGenero.Text, cbEspecialidad.Text, txtCodigo.Text, Encrypt.CreateSHA256(txtContra.Text));
                            MessageBox.Show("Médico se creó correctamente!", "´Médico Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarMedicos();
                            limpiarCampos();
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show($"No se pudo crear el registro del Médico: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (Editar == true)
                    {
                        try
                        {
                            objetoCN.EditarMedico(txtNombre.Text, txtEdad.Text, cbGenero.Text, cbEspecialidad.Text, txtCodigo.Text, Encrypt.CreateSHA256(txtContra.Text), idMedico);
                            MessageBox.Show("Médico se editó correctamente", "Editado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarMedicos();
                            limpiarCampos();
                            Editar = false;
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show($"No se pudo editar el registro del Médico: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ActualizarMedico()
        {
            try
            {
                if (dgvMedicos.SelectedRows.Count > 0)
                {
                    Editar = true;
                    txtNombre.Text = dgvMedicos.CurrentRow.Cells["nombre"].Value.ToString();
                    txtEdad.Text = dgvMedicos.CurrentRow.Cells["edad"].Value.ToString();
                    cbGenero.Text = dgvMedicos.CurrentRow.Cells["genero"].Value.ToString();
                    cbEspecialidad.Text = dgvMedicos.CurrentRow.Cells["especialidad"].Value.ToString();
                    txtCodigo.Text = dgvMedicos.CurrentRow.Cells["codigo"].Value.ToString();
                    txtContra.Text = Encrypt.GetSHA256(dgvMedicos.CurrentRow.Cells["contraMedico"].Value.ToString().Trim());
                    idMedico = dgvMedicos.CurrentRow.Cells["id"].Value.ToString();
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

        private void EliminarMedico()
        {
            try
            {
                if (dgvMedicos.SelectedRows.Count > 0)
                {
                    idMedico = dgvMedicos.CurrentRow.Cells["id"].Value.ToString();
                    objetoCN.EliminarMedico(idMedico);
                    MessageBox.Show("Medico eliminado correctamente!", "Medico Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarMedicos();
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
            txtContra.Clear();
            txtEdad.Clear();
            cbEspecialidad.Text = "";
            txtNombre.Clear();
        }

        private void Médico_Load(object sender, EventArgs e)
        {
            MostrarMedicos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarMedico();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarMedico();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarMedico();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            SalaPrincipalAdministrador admin = new SalaPrincipalAdministrador();
            admin.Show();
            this.Close();
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEspecialidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtGenero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

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

        private void cbEspecialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras y espacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}

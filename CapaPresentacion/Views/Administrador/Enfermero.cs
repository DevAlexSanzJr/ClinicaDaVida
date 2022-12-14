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
    public partial class Enfermero : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public Enfermero()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        CN_Enfermero objetoCN = new CN_Enfermero();
        private string idEnfermero = null;
        private bool Editar = false;

        private void MostrarEnfermeros()
        {
            CN_Enfermero objeto = new CN_Enfermero();
            dgvEnfermeros.DataSource = objeto.MostrarEnfermeros();
        }

        private void GuardarEnfermero()
        {
            try
            {
                if (txtNombre.Text != "" && txtEdad.Text != "" && cbGenero.Text != "" && txtCodigo.Text != "" && txtContra.Text != "")
                {
                    if (Editar == false)
                    {
                        try
                        {
                            objetoCN.CrearEnfermero(txtNombre.Text, Convert.ToInt32(txtEdad.Text), cbGenero.Text, txtCodigo.Text, Encrypt.CreateSHA256(txtContra.Text));
                            MessageBox.Show("Enfermero se creó correctamente!", "´Enfermero Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarEnfermeros();
                            limpiarCampos();
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show($"No se pudo crear el registro del Enfermero: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (Editar == true)
                    {
                        try
                        {
                            objetoCN.EditarEnfermero(txtNombre.Text, txtEdad.Text, cbGenero.Text, txtCodigo.Text, Encrypt.CreateSHA256(txtContra.Text), idEnfermero);
                            MessageBox.Show("Enfermero se editó correctamente", "Editado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarEnfermeros();
                            limpiarCampos();
                            Editar = false;
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show($"No se pudo editar el registro del Enfermero: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ActualizarEnfermero()
        {
            try
            {
                if (dgvEnfermeros.SelectedRows.Count > 0)
                {
                    Editar = true;
                    txtNombre.Text = dgvEnfermeros.CurrentRow.Cells["nombre"].Value.ToString();
                    txtEdad.Text = dgvEnfermeros.CurrentRow.Cells["edad"].Value.ToString();
                    cbGenero.Text = dgvEnfermeros.CurrentRow.Cells["genero"].Value.ToString();
                    txtCodigo.Text = dgvEnfermeros.CurrentRow.Cells["codigo"].Value.ToString();
                    txtContra.Text = Encrypt.GetSHA256(dgvEnfermeros.CurrentRow.Cells["contraEnfermero"].Value.ToString().Trim());
                    idEnfermero = dgvEnfermeros.CurrentRow.Cells["id"].Value.ToString();
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

        private void EliminarEnfermero()
        {
            try
            {
                if (dgvEnfermeros.SelectedRows.Count > 0)
                {
                    idEnfermero = dgvEnfermeros.CurrentRow.Cells["id"].Value.ToString();
                    objetoCN.EliminarEnfermero(idEnfermero);
                    MessageBox.Show("Enfermero eliminado correctamente!", "Enfermero Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarEnfermeros();
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
            txtNombre.Clear();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            SalaPrincipalAdministrador administrador = new SalaPrincipalAdministrador();
            administrador.Show();
            this.Close();
        }

        private void Enfermero_Load(object sender, EventArgs e)
        {
            MostrarEnfermeros();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarEnfermero();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarEnfermero();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarEnfermero();
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != char.Parse(" ")))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
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

        private void cbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

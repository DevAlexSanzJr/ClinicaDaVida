using CapaNegocio;
using CapaPresentacion.Views.Administrador;
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

namespace CapaPresentacion.Views
{
    public partial class Medicamentos : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public Medicamentos()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        CN_Medicamento objetoCN = new CN_Medicamento();
        private string idMedicamento = null;
        private bool Editar = false;

        private void MostrarMedicamentos()
        {
            CN_Medicamento objeto = new CN_Medicamento();
            dgvMedicamentos.DataSource = objeto.MostrarMedicamento();
        }

        private void GuardarMedicamento()
        {
            try
            {
                if (txtNombre.Text != "" && txtDesc.Text != "" && txtEfectosSec.Text != "" && cbMarca.Text != "")
                {
                    if (Editar == false)
                    {
                        try
                        {
                            objetoCN.CrearMedicamento(txtNombre.Text, txtDesc.Text, txtEfectosSec.Text, cbMarca.Text);
                            MessageBox.Show("Su medicamento se creó correctamente!", "Medicamento Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarMedicamentos();
                            limpiarCampos();
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show($"No se pudo crear el medicamento: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (Editar == true)
                    {
                        try
                        {
                            objetoCN.EditarMedicamento(txtNombre.Text, txtDesc.Text, txtEfectosSec.Text, cbMarca.Text, idMedicamento);
                            MessageBox.Show("Su medicamento se editó correctamente", "Editado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarMedicamentos();
                            limpiarCampos();
                            Editar = false;
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show($"No se pudo editar lel medicamento: {err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ActualizarMedicamento()
        {
            try
            {
                if (dgvMedicamentos.SelectedRows.Count > 0)
                {
                    Editar = true;
                    txtNombre.Text = dgvMedicamentos.CurrentRow.Cells["nombre"].Value.ToString();
                    cbMarca.Text = dgvMedicamentos.CurrentRow.Cells["marca"].Value.ToString();
                    txtDesc.Text = dgvMedicamentos.CurrentRow.Cells["descripcion"].Value.ToString();
                    txtEfectosSec.Text = dgvMedicamentos.CurrentRow.Cells["efectosSecundarios"].Value.ToString();
                    idMedicamento = dgvMedicamentos.CurrentRow.Cells["id"].Value.ToString();
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

        private void EliminarMedicamento()
        {
            try
            {
                if (dgvMedicamentos.SelectedRows.Count > 0)
                {
                    idMedicamento = dgvMedicamentos.CurrentRow.Cells["id"].Value.ToString();
                    objetoCN.EliminarMedicamento(idMedicamento);
                    MessageBox.Show("Medicamento eliminado correctamente!", "Medicamento Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarMedicamentos();
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
            txtDesc.Clear();
            txtEfectosSec.Clear();
            cbMarca.Text = "";
            txtNombre.Clear();
        }

        private void Medicamentos_Load(object sender, EventArgs e)
        {
            MostrarMedicamentos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarMedicamento();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarMedicamento();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarMedicamento();
        }

        private void txtEfectosSec_TextChanged(object sender, EventArgs e)
        {

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            InicioSesion sala = new InicioSesion();
            sala.Show();
            this.Close();
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

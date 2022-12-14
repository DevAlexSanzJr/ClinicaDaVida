using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_ConsultasEnfermero
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarConsultaEnfermero";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Crear(string nombrePaciente, string nombreMedico, string descripcion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CrearConsultaEnfermero";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombrePaciente", nombrePaciente);
            comando.Parameters.AddWithValue("@nombreMedico", nombreMedico);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(string nombrePaciente, string nombreMedico, string descripcion, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarConsultaEnfermero";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombrePaciente", nombrePaciente);
            comando.Parameters.AddWithValue("@nombreMedico", nombreMedico);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarConsultaEnfermero";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public DataTable MostrarMedicos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarMedicosEnfermeros";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}

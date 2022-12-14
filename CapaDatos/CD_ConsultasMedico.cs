using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_ConsultasMedico
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarDiagnostico";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Crear(string nombrePaciente, string nombreMedico, string descripcion, string diagnostico, string medicamentoUno, string medicamentoDos, string medicamentoTres, string medicamentoCuatro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CrearDiagnostico";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombrePaciente", nombrePaciente);
            comando.Parameters.AddWithValue("@nombreMedico", nombreMedico);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@diagnostico", diagnostico);
            comando.Parameters.AddWithValue("@medicamentoUno", medicamentoUno);
            comando.Parameters.AddWithValue("@medicamentoDos", medicamentoDos);
            comando.Parameters.AddWithValue("@medicamentoTres", medicamentoTres);
            comando.Parameters.AddWithValue("@medicamentoCuatro", medicamentoCuatro);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        
        public void Editar(string nombrePaciente, string nombreMedico, string descripcion, string diagnostico, string medicamentoUno, string medicamentoDos, string medicamentoTres, string medicamentoCuatro, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarDiagnostico";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombrePaciente", nombrePaciente);
            comando.Parameters.AddWithValue("@nombreMedico", nombreMedico);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@diagnostico", diagnostico);
            comando.Parameters.AddWithValue("@medicamentoUno", medicamentoUno);
            comando.Parameters.AddWithValue("@medicamentoDos", medicamentoDos);
            comando.Parameters.AddWithValue("@medicamentoTres", medicamentoTres);
            comando.Parameters.AddWithValue("@medicamentoCuatro", medicamentoCuatro);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarDiagnostico";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}

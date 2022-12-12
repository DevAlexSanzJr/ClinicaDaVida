using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Paciente
    {
        private CD_Paciente objetoCD = new CD_Paciente();

        public DataTable MostrarPacientes()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void CrearPaciente(string nombre, int edad, string genero, string codigo)
        {
            objetoCD.Crear(nombre, Convert.ToInt32(edad), genero, codigo);
        }

        public void EditarPaciente(string nombre, string edad, string genero, string codigo, string id)
        {
            objetoCD.Editar(nombre, Convert.ToInt32(edad), genero, codigo, Convert.ToInt32(id));
        }

        public void EliminarPaciente(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}

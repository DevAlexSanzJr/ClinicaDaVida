using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Medico
    {
        private CD_Medico objetoCD = new CD_Medico();

        public DataTable MostrarMedicos()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void CrearMedico(string nombre, int edad, string genero, string especialidad, string codigo, string contraMedico)
        {
            objetoCD.Crear(nombre, Convert.ToInt32(edad), genero, especialidad, codigo, contraMedico);
        }

        public void EditarMedico(string nombre, string edad, string genero, string especialidad, string codigo, string contraMedico, string id)
        {
            objetoCD.Editar(nombre, Convert.ToInt32(edad), genero, especialidad, codigo, contraMedico, Convert.ToInt32(id));
        }

        public void EliminarMedico(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}

using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Enfermero
    {
        private CD_Enfermero objetoCD = new CD_Enfermero();

        public DataTable MostrarEnfermeros()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void CrearEnfermero(string nombre, int edad, string genero, string codigo, string contraEnfermero)
        {
            objetoCD.Crear(nombre, Convert.ToInt32(edad), genero, codigo, contraEnfermero);
        }

        public void EditarEnfermero(string nombre, string edad, string genero, string codigo, string contraEnfermero, string id)
        {
            objetoCD.Editar(nombre, Convert.ToInt32(edad), genero, codigo, contraEnfermero, Convert.ToInt32(id));
        }

        public void EliminarEnfermero(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}

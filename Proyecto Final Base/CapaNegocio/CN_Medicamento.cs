using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Medicamento
    {
        private CD_Medicamento objetoCD = new CD_Medicamento();

        public DataTable MostrarMedicamento()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void CrearMedicamento(string nombre, string desc, string efectosSec, string marca)
        {
            objetoCD.Crear(nombre, desc, efectosSec, marca);
        }

        public void EditarMedicamento(string nombre, string desc, string efectosSec, string marca, string id)
        {
            objetoCD.Editar(nombre, desc, efectosSec, marca, Convert.ToInt32(id));
        }

        public void EliminarMedicamento(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}

using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_ConsultasEnfermero
    {
        private CD_ConsultasEnfermero objetoCD = new CD_ConsultasEnfermero();

        public DataTable MostrarConsultasEnfermero()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void CrearConsultasEnfermero(string nombrePaciente, string nombreMedico, string descripcion)
        {
            objetoCD.Crear(nombrePaciente, nombreMedico, descripcion);
        }

        public void EditarConsultasEnfermero(string nombrePaciente, string nombreMedico, string descripcion, string id)
        {
            objetoCD.Editar(nombrePaciente,  nombreMedico, descripcion, Convert.ToInt32(id));
        }

        public void EliminarConsultasEnfermero(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
        public DataTable MostrarMedicosEnfermero()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarMedicos();
            return tabla;
        }
    }
}

using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_ConsultasMedico
    {
        private CD_ConsultasMedico objetoCD = new CD_ConsultasMedico();

        public DataTable MostrarConsultasMedico()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void CrearConsultasMedico(string nombrePaciente, string nombreMedico, string descripcion, string diagnostico, string medicamentoUno, string medicamentoDos, string medicamentoTres, string medicamentoCuatro)
        {
            objetoCD.Crear(nombrePaciente, nombreMedico, descripcion, diagnostico, medicamentoUno, medicamentoDos, medicamentoTres, medicamentoCuatro);
        }

        public void EditarConsultasMedico(string nombrePaciente, string nombreMedico, string descripcion, string diagnostico, string medicamentoUno, string medicamentoDos, string medicamentoTres, string medicamentoCuatro, string id)
        {
            objetoCD.Editar(nombrePaciente, nombreMedico, descripcion, diagnostico, medicamentoUno, medicamentoDos, medicamentoTres, medicamentoCuatro,Convert.ToInt32(id));
        }

        public void EliminarConsultasMedico(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}

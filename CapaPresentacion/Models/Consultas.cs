//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaPresentacion.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Consultas
    {
        public int id { get; set; }
        public Nullable<int> idPaciente { get; set; }
        public Nullable<int> idMedico { get; set; }
        public Nullable<int> medicamento_Uno { get; set; }
        public Nullable<int> medicamento_Dos { get; set; }
        public Nullable<int> medicamento_Tres { get; set; }
        public Nullable<int> medicamento_Cuatro { get; set; }
        public string descripcion { get; set; }
        public string diagnostico { get; set; }
    
        public virtual Medicos Medicos { get; set; }
        public virtual Pacientes Pacientes { get; set; }
        public virtual Medicamentos Medicamentos { get; set; }
        public virtual Medicamentos Medicamentos1 { get; set; }
        public virtual Medicamentos Medicamentos2 { get; set; }
        public virtual Medicamentos Medicamentos3 { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class Egreso
    {
        public int Egreso_Id { get; set; }
        public string Egreso_PagadoA { get; set; }
        public string Egreso_Cedula { get; set; }
        public Nullable<double> Egreso_Monto { get; set; }
        public string Egreso_Concepto { get; set; }
        public string Egreso_Preparado { get; set; }
        public string Egresp_Aprobado { get; set; }
        public string Egreso_Recibido { get; set; }
        public System.DateTime Egreso_FechaCreacion { get; set; }
        public Nullable<int> Egreso_IdUsuarioCreador { get; set; }
        public bool Egreso_Vigencia { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
    }
}

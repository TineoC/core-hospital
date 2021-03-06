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
    
    public partial class Cuentas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cuentas()
        {
            this.Cuenta_Factura = new HashSet<Cuenta_Factura>();
            this.Pago = new HashSet<Pago>();
        }
    
        public int Cuenta_Id { get; set; }
        public string Cuenta_IdPersona { get; set; }
        public Nullable<decimal> Cuenta_Balance { get; set; }
        public System.DateTime Cuenta_FechaCreacion { get; set; }
        public Nullable<int> Cuenta_IdUsuarioCreador { get; set; }
        public bool Cuenta_Vigencia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cuenta_Factura> Cuenta_Factura { get; set; }
        public virtual Persona Persona { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pago> Pago { get; set; }
    }
}

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
    
    public partial class AperturaYCierreDeCaja
    {
        public int AperturaYCierreDeCaja_Id { get; set; }
        public Nullable<int> AperturaYCierreDeCaja_IdCaja { get; set; }
        public Nullable<int> AperturaYCierreDeCaja_DosMIlPesos { get; set; }
        public Nullable<int> AperturaYCierreDeCaja_MIlPesos { get; set; }
        public Nullable<int> AperturaYCierreDeCaja_QuinientosPeso { get; set; }
        public Nullable<int> AperturaYCierreDeCaja_DoscientosPesos { get; set; }
        public Nullable<int> AperturaYCierreDeCaja_CienPesos { get; set; }
        public Nullable<int> AperturaYCierreDeCaja_CincuentaPesos { get; set; }
        public Nullable<int> AperturaYCierreDeCaja_25Pesos { get; set; }
        public Nullable<int> AperturaYCierreDeCaja_10Pesos { get; set; }
        public Nullable<int> AperturaYCierreDeCaja_5Peso { get; set; }
        public Nullable<int> AperturaYCierreDeCaja_1Peso { get; set; }
        public Nullable<int> AperturaYCierreDeCaja_TotalEfectivo { get; set; }
        public Nullable<decimal> AperturaYCierreDeCaja_TotalCredito { get; set; }
        public Nullable<decimal> AperturaYCierreDeCaja_TotalTarjeta { get; set; }
        public Nullable<decimal> AperturaYCierreDeCaja_Transferencia { get; set; }
        public Nullable<decimal> AperturaYCierreDeCaja_Deposito { get; set; }
        public Nullable<decimal> AperturaYCierreDeCaja_TotalCheques { get; set; }
        public Nullable<decimal> AperturaYCierreDeCaja_TotalGeneral { get; set; }
        public Nullable<bool> AperturaYCierreDeCaja_AperturaOCierre { get; set; }
        public System.DateTime AperturaYCierreDeCaja_Fecha { get; set; }
        public Nullable<int> AperturaYCierreDeCaja_IdUsuarioCreador { get; set; }
        public bool AperturaYCierreDeCaja_Vigencia { get; set; }
    
        public virtual Caja Caja { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}

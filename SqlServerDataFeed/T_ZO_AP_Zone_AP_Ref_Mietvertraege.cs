//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SqlServerDataFeed
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_ZO_AP_Zone_AP_Ref_Mietvertraege
    {
        public System.Guid ZO_ZNVTR_UID { get; set; }
        public System.Guid ZO_ZNVTR_ZN_UID { get; set; }
        public System.Guid ZO_ZNVTR_VTR_UID { get; set; }
        public System.DateTime ZO_ZNVTR_DatumVon { get; set; }
        public System.DateTime ZO_ZNVTR_DatumBis { get; set; }
        public int ZO_ZNVTR_Status { get; set; }
        public double ZO_ZNVTR_PreisM2 { get; set; }
        public double ZO_ZNVTR_Flaeche { get; set; }
        public string ZO_ZNVTR_Bemerkung { get; set; }
        public double ZO_ZNVTR_FlaecheProzent { get; set; }
    
        public virtual T_AP_Zone T_AP_Zone { get; set; }
        public virtual T_VM_Vertraege T_VM_Vertraege { get; set; }
    }
}
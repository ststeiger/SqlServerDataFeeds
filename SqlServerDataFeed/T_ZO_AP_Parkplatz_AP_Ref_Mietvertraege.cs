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
    
    public partial class T_ZO_AP_Parkplatz_AP_Ref_Mietvertraege
    {
        public System.Guid ZO_PPVTR_UID { get; set; }
        public System.Guid ZO_PPVTR_PP_UID { get; set; }
        public System.Guid ZO_PPVTR_VTR_UID { get; set; }
        public System.DateTime ZO_PPVTR_DatumVon { get; set; }
        public System.DateTime ZO_PPVTR_DatumBis { get; set; }
        public int ZO_PPVTR_Status { get; set; }
        public double ZO_PPVTR_PreisM2 { get; set; }
        public double ZO_PPVTR_Flaeche { get; set; }
        public double ZO_PPVTR_Mietansatz { get; set; }
        public string ZO_PPVTR_Schild { get; set; }
        public string ZO_PPVTR_Bemerkung { get; set; }
        public Nullable<double> ZO_PPVTR_FlaecheProzent { get; set; }
    
        public virtual T_AP_Parkplatz T_AP_Parkplatz { get; set; }
        public virtual T_VM_Vertraege T_VM_Vertraege { get; set; }
    }
}

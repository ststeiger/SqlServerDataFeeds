//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SqlServerDataFeedEF6
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_ZO_AP_Zone_AP_Ref_Anmietvertraege
    {
        public System.Guid ZO_ZNANVTR_UID { get; set; }
        public System.Guid ZO_ZNANVTR_ZN_UID { get; set; }
        public System.Guid ZO_ZNANVTR_VTR_UID { get; set; }
        public System.DateTime ZO_ZNANVTR_DatumVon { get; set; }
        public System.DateTime ZO_ZNANVTR_DatumBis { get; set; }
        public int ZO_ZNANVTR_Status { get; set; }
        public double ZO_ZNANVTR_PreisM2 { get; set; }
        public double ZO_ZNANVTR_Flaeche { get; set; }
        public string ZO_ZNANVTR_Bemerkung { get; set; }
        public double ZO_ZNANVTR_FlaecheProzent { get; set; }
    
        public virtual T_AP_Zone T_AP_Zone { get; set; }
        public virtual T_VM_Vertraege T_VM_Vertraege { get; set; }
    }
}
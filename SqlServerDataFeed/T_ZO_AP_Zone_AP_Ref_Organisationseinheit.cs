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
    
    public partial class T_ZO_AP_Zone_AP_Ref_Organisationseinheit
    {
        public System.Guid ZO_ZNKOE_UID { get; set; }
        public System.Guid ZO_ZNKOE_ZN_UID { get; set; }
        public System.Guid ZO_ZNKOE_KOE_UID { get; set; }
        public System.DateTime ZO_ZNKOE_DatumVon { get; set; }
        public System.DateTime ZO_ZNKOE_DatumBis { get; set; }
        public int ZO_ZNKOE_Status { get; set; }
        public string ZO_ZNKOE_Bemerkung { get; set; }
        public Nullable<bool> ZO_ZNKOE_IsFromOdis { get; set; }
        public double ZO_ZNKOE_FlaecheProz { get; set; }
    
        public virtual T_AP_Ref_Organisationseinheit T_AP_Ref_Organisationseinheit { get; set; }
        public virtual T_AP_Zone T_AP_Zone { get; set; }
    }
}

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
    
    public partial class T_ZO_AP_Raum_AP_Ref_Organisationseinheit
    {
        public System.Guid ZO_RMKOE_UID { get; set; }
        public System.Guid ZO_RMKOE_RM_UID { get; set; }
        public System.Guid ZO_RMKOE_KOE_UID { get; set; }
        public System.DateTime ZO_RMKOE_DatumVon { get; set; }
        public System.DateTime ZO_RMKOE_DatumBis { get; set; }
        public int ZO_RMKOE_Status { get; set; }
        public string ZO_RMKOE_Bemerkung { get; set; }
        public Nullable<bool> ZO_RMKOE_IsFromOdis { get; set; }
        public Nullable<int> ZO_RMKOE_AnzahlAP { get; set; }
        public double ZO_RMKOE_FlaecheProz { get; set; }
    
        public virtual T_AP_Raum T_AP_Raum { get; set; }
        public virtual T_AP_Ref_Organisationseinheit T_AP_Ref_Organisationseinheit { get; set; }
    }
}
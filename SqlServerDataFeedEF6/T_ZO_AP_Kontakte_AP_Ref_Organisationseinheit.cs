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
    
    public partial class T_ZO_AP_Kontakte_AP_Ref_Organisationseinheit
    {
        public System.Guid ZO_KTKOE_UID { get; set; }
        public System.Guid ZO_KTKOE_KT_UID { get; set; }
        public System.Guid ZO_KTKOE_KOE_UID { get; set; }
        public System.DateTime ZO_KTKOE_DatumVon { get; set; }
        public System.DateTime ZO_KTKOE_DatumBis { get; set; }
        public int ZO_KTKOE_Status { get; set; }
        public Nullable<bool> ZO_KTKOE_IsFromOdis { get; set; }
        public string ZO_KTKOE_Bemerkung { get; set; }
    
        public virtual T_AP_Kontakte T_AP_Kontakte { get; set; }
        public virtual T_AP_Ref_Organisationseinheit T_AP_Ref_Organisationseinheit { get; set; }
    }
}

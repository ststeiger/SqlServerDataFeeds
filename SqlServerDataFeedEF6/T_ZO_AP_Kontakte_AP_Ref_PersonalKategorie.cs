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
    
    public partial class T_ZO_AP_Kontakte_AP_Ref_PersonalKategorie
    {
        public System.Guid ZO_KTPK_UID { get; set; }
        public System.Guid ZO_KTPK_KT_UID { get; set; }
        public System.Guid ZO_KTPK_PK_UID { get; set; }
        public System.DateTime ZO_KTPK_DatumVon { get; set; }
        public System.DateTime ZO_KTPK_DatumBis { get; set; }
        public int ZO_KTPK_Status { get; set; }
        public Nullable<bool> ZO_KTPK_IsFromOdis { get; set; }
    
        public virtual T_AP_Kontakte T_AP_Kontakte { get; set; }
        public virtual T_AP_Ref_PersonalKategorie T_AP_Ref_PersonalKategorie { get; set; }
    }
}

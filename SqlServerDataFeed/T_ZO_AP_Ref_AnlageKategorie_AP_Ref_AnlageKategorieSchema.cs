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
    
    public partial class T_ZO_AP_Ref_AnlageKategorie_AP_Ref_AnlageKategorieSchema
    {
        public System.Guid ZO_AKAKS_UID { get; set; }
        public Nullable<System.Guid> ZO_AKAKS_AK_UID { get; set; }
        public System.Guid ZO_AKAKS_AKS_UID { get; set; }
        public int ZO_AKAKS_Status { get; set; }
    
        public virtual T_AP_Ref_AnlageKategorie T_AP_Ref_AnlageKategorie { get; set; }
        public virtual T_AP_Ref_AnlageKategorieSchema T_AP_Ref_AnlageKategorieSchema { get; set; }
    }
}

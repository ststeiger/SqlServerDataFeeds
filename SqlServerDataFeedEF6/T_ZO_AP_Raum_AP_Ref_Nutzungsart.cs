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
    
    public partial class T_ZO_AP_Raum_AP_Ref_Nutzungsart
    {
        public System.Guid ZO_RMNA_UID { get; set; }
        public Nullable<System.Guid> ZO_RMNA_RM_UID { get; set; }
        public Nullable<System.Guid> ZO_RMNA_NA_UID { get; set; }
        public System.DateTime ZO_RMNA_DatumVon { get; set; }
        public System.DateTime ZO_RMNA_DatumBis { get; set; }
        public int ZO_RMNA_Status { get; set; }
    
        public virtual T_AP_Raum T_AP_Raum { get; set; }
        public virtual T_AP_Ref_Nutzungsart T_AP_Ref_Nutzungsart { get; set; }
    }
}

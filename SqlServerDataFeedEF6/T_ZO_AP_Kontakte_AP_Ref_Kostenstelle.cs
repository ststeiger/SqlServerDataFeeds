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
    
    public partial class T_ZO_AP_Kontakte_AP_Ref_Kostenstelle
    {
        public System.Guid ZO_KTKST_UID { get; set; }
        public System.Guid ZO_KTKST_KT_UID { get; set; }
        public System.Guid ZO_KTKST_KST_UID { get; set; }
        public System.DateTime ZO_KTKST_DatumVon { get; set; }
        public System.DateTime ZO_KTKST_DatumBis { get; set; }
        public int ZO_KTKST_Status { get; set; }
    
        public virtual T_AP_Kontakte T_AP_Kontakte { get; set; }
        public virtual T_AP_Ref_Kostenstelle T_AP_Ref_Kostenstelle { get; set; }
    }
}

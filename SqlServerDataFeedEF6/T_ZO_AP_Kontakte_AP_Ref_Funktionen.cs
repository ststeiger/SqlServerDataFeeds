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
    
    public partial class T_ZO_AP_Kontakte_AP_Ref_Funktionen
    {
        public System.Guid ZO_KTKF_UID { get; set; }
        public Nullable<System.Guid> ZO_KTKF_KT_UID { get; set; }
        public Nullable<System.Guid> ZO_KTKF_KF_UID { get; set; }
        public int ZO_KTKF_Status { get; set; }
    
        public virtual T_AP_Kontakte T_AP_Kontakte { get; set; }
        public virtual T_AP_Ref_KontakFunktion T_AP_Ref_KontakFunktion { get; set; }
    }
}

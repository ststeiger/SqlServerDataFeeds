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
    
    public partial class T_ZO_AP_Schluesselgruppe_AP_Ref_Funktionen
    {
        public System.Guid ZO_SLGKF_UID { get; set; }
        public Nullable<System.Guid> ZO_SLGKF_SLG_UID { get; set; }
        public Nullable<System.Guid> ZO_SLGKF_KF_UID { get; set; }
        public int ZO_SLGKF_Status { get; set; }
    
        public virtual T_AP_Ref_KontakFunktion T_AP_Ref_KontakFunktion { get; set; }
        public virtual T_AP_Schluesselgruppe T_AP_Schluesselgruppe { get; set; }
    }
}

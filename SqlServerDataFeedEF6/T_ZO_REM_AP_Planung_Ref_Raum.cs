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
    
    public partial class T_ZO_REM_AP_Planung_Ref_Raum
    {
        public int ZO_RMRPR_REMSP_Nr { get; set; }
        public System.Guid ZO_RMRPR_RM_UID { get; set; }
        public Nullable<int> ZO_RMRPR_Status { get; set; }
        public string ZO_RMRPR_Reinigungstag { get; set; }
        public string ZO_RMRPR_Sort { get; set; }
    
        public virtual T_AP_Raum T_AP_Raum { get; set; }
        public virtual T_ZO_REM_AP_Standort_Planung T_ZO_REM_AP_Standort_Planung { get; set; }
    }
}

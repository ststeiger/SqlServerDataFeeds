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
    
    public partial class T_ZO_REM_AP_Raum_Ref_Ausbau
    {
        public System.Guid ZO_RMREMAB_UID { get; set; }
        public System.Guid ZO_RMREMAB_RM_UID { get; set; }
        public System.Guid ZO_RMREMAB_REMAB_UID { get; set; }
        public double ZO_RMREMAB_Menge { get; set; }
        public System.DateTime ZO_RMREMAB_GueltigVon { get; set; }
        public System.DateTime ZO_RMREMAB_GueltigBis { get; set; }
        public int ZO_RMREMAB_Status { get; set; }
    
        public virtual T_AP_Raum T_AP_Raum { get; set; }
        public virtual T_REM_Ref_Ausbau T_REM_Ref_Ausbau { get; set; }
    }
}

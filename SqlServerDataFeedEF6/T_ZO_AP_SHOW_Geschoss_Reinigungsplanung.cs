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
    
    public partial class T_ZO_AP_SHOW_Geschoss_Reinigungsplanung
    {
        public System.Guid ZO_GSSRSP_GS_UID { get; set; }
        public string ZO_GSSRSP_DWG { get; set; }
        public int ZO_GSSRSP_REMSP_Nr { get; set; }
    
        public virtual T_AP_Geschoss T_AP_Geschoss { get; set; }
        public virtual T_ZO_REM_AP_Standort_Planung T_ZO_REM_AP_Standort_Planung { get; set; }
    }
}

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
    
    public partial class T_ZO_AP_Kunst_AP_Ref_KunstKuenstler
    {
        public System.Guid ZO_KUKK_UID { get; set; }
        public System.Guid ZO_KUKK_KU_UID { get; set; }
        public System.Guid ZO_KUKK_KK_UID { get; set; }
        public int ZO_KUKK_Status { get; set; }
    
        public virtual T_AP_Kunst T_AP_Kunst { get; set; }
        public virtual T_AP_Ref_KunstKuenstler T_AP_Ref_KunstKuenstler { get; set; }
    }
}
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
    
    public partial class T_SYS_Zonerechte
    {
        public System.Guid ZNR_UID { get; set; }
        public int ZNR_MDT_ID { get; set; }
        public int ZNR_GRANTEE_ID { get; set; }
        public Nullable<System.Guid> ZNR_ZN_UID { get; set; }
        public bool ZNR_IsRead { get; set; }
        public bool ZNR_IsWrite { get; set; }
        public bool ZNR_IsInsert { get; set; }
        public bool ZNR_IsDelete { get; set; }
        public int ZNR_Status { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_AP_Zone T_AP_Zone { get; set; }
        public virtual T_Benutzergruppen T_Benutzergruppen { get; set; }
    }
}
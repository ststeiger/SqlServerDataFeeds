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
    
    public partial class T_SYS_BackOfficeMenuerechte
    {
        public System.Guid BOMR_UID { get; set; }
        public int BOMR_GRANTEE_ID { get; set; }
        public string BOMR_GRANTEE { get; set; }
        public Nullable<System.Guid> BOMR_BOSM_UID { get; set; }
        public bool BOMR_IsRead { get; set; }
        public bool BOMR_IsWrite { get; set; }
        public bool BOMR_IsInsert { get; set; }
        public bool BOMR_IsDelete { get; set; }
        public int BOMR_Status { get; set; }
        public int BOMR_MDT_ID { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_Ref_BackOfficeSubMenue T_SYS_Ref_BackOfficeSubMenue { get; set; }
    }
}

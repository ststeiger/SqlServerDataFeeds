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
    
    public partial class T_SYS_Informatikrechte
    {
        public System.Guid INR_UID { get; set; }
        public int INR_MDT_ID { get; set; }
        public int INR_GRANTEE_ID { get; set; }
        public Nullable<System.Guid> INR_IN_UID { get; set; }
        public bool INR_IsRead { get; set; }
        public bool INR_IsWrite { get; set; }
        public bool INR_IsInsert { get; set; }
        public bool INR_IsDelete { get; set; }
        public int INR_Status { get; set; }
    
        public virtual T_AP_Informatik T_AP_Informatik { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_Benutzergruppen T_Benutzergruppen { get; set; }
    }
}

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
    
    public partial class T_SYS_Aussenobjektrechte
    {
        public System.Guid AOR_UID { get; set; }
        public int AOR_MDT_ID { get; set; }
        public int AOR_GRANTEE_ID { get; set; }
        public Nullable<System.Guid> AOR_AO_UID { get; set; }
        public bool AOR_IsRead { get; set; }
        public bool AOR_IsWrite { get; set; }
        public bool AOR_IsInsert { get; set; }
        public bool AOR_IsDelete { get; set; }
        public int AOR_Status { get; set; }
    
        public virtual T_AP_Aussenobjekt T_AP_Aussenobjekt { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_Benutzergruppen T_Benutzergruppen { get; set; }
    }
}

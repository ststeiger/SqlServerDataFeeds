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
    
    public partial class T_SYS_Mobiliarrechte
    {
        public System.Guid MOR_UID { get; set; }
        public int MOR_MDT_ID { get; set; }
        public int MOR_GRANTEE_ID { get; set; }
        public Nullable<System.Guid> MOR_MO_UID { get; set; }
        public bool MOR_IsRead { get; set; }
        public bool MOR_IsWrite { get; set; }
        public bool MOR_IsInsert { get; set; }
        public bool MOR_IsDelete { get; set; }
        public int MOR_Status { get; set; }
    
        public virtual T_AP_Mobiliar T_AP_Mobiliar { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_Benutzergruppen T_Benutzergruppen { get; set; }
    }
}

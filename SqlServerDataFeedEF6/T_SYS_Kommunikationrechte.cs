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
    
    public partial class T_SYS_Kommunikationrechte
    {
        public System.Guid KMR_UID { get; set; }
        public int KMR_MDT_ID { get; set; }
        public int KMR_GRANTEE_ID { get; set; }
        public Nullable<System.Guid> KMR_KM_UID { get; set; }
        public bool KMR_IsRead { get; set; }
        public bool KMR_IsWrite { get; set; }
        public bool KMR_IsInsert { get; set; }
        public bool KMR_IsDelete { get; set; }
        public int KMR_Status { get; set; }
    
        public virtual T_AP_Kommunikation T_AP_Kommunikation { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_Benutzergruppen T_Benutzergruppen { get; set; }
    }
}

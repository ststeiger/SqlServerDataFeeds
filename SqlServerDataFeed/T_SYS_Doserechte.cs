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
    
    public partial class T_SYS_Doserechte
    {
        public System.Guid DOR_UID { get; set; }
        public int DOR_MDT_ID { get; set; }
        public int DOR_GRANTEE_ID { get; set; }
        public Nullable<System.Guid> DOR_DO_UID { get; set; }
        public bool DOR_IsRead { get; set; }
        public bool DOR_IsWrite { get; set; }
        public bool DOR_IsInsert { get; set; }
        public bool DOR_IsDelete { get; set; }
        public int DOR_Status { get; set; }
    
        public virtual T_AP_Dose T_AP_Dose { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_Benutzergruppen T_Benutzergruppen { get; set; }
    }
}

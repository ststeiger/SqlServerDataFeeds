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
    
    public partial class T_SYS_Parkplatzrechte
    {
        public System.Guid PPR_UID { get; set; }
        public int PPR_MDT_ID { get; set; }
        public int PPR_GRANTEE_ID { get; set; }
        public Nullable<System.Guid> PPR_PP_UID { get; set; }
        public bool PPR_IsRead { get; set; }
        public bool PPR_IsWrite { get; set; }
        public bool PPR_IsInsert { get; set; }
        public bool PPR_IsDelete { get; set; }
        public int PPR_Status { get; set; }
    
        public virtual T_AP_Parkplatz T_AP_Parkplatz { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_Benutzergruppen T_Benutzergruppen { get; set; }
    }
}

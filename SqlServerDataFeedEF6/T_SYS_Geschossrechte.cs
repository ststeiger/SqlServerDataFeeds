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
    
    public partial class T_SYS_Geschossrechte
    {
        public System.Guid GSR_UID { get; set; }
        public int GSR_GRANTEE_ID { get; set; }
        public string GSR_GRANTEE { get; set; }
        public Nullable<System.Guid> GSR_GS_UID { get; set; }
        public Nullable<System.Guid> GSR_GB_UID { get; set; }
        public bool GSR_IsRead { get; set; }
        public bool GSR_IsWrite { get; set; }
        public bool GSR_IsInsert { get; set; }
        public bool GSR_IsDelete { get; set; }
        public int GSR_Status { get; set; }
        public int GSR_MDT_ID { get; set; }
    
        public virtual T_AP_Gebaeude T_AP_Gebaeude { get; set; }
        public virtual T_AP_Geschoss T_AP_Geschoss { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_Benutzergruppen T_Benutzergruppen { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SqlServerDataFeed
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_SYS_Navigationrechte
    {
        public System.Guid NAR_UID { get; set; }
        public int NAR_GRANTEE_ID { get; set; }
        public string NAR_GRANTEE { get; set; }
        public Nullable<System.Guid> NAR_NA_UID { get; set; }
        public bool NAR_IsRead { get; set; }
        public int NAR_Status { get; set; }
        public int NAR_MDT_ID { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
    }
}

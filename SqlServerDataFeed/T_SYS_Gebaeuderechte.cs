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
    
    public partial class T_SYS_Gebaeuderechte
    {
        public System.Guid GBR_UID { get; set; }
        public int GBR_GRANTEE_ID { get; set; }
        public string GBR_GRANTEE { get; set; }
        public Nullable<System.Guid> GBR_GB_UID { get; set; }
        public Nullable<System.Guid> GBR_SO_UID { get; set; }
        public bool GBR_IsRead { get; set; }
        public bool GBR_IsWrite { get; set; }
        public bool GBR_IsInsert { get; set; }
        public bool GBR_IsDelete { get; set; }
        public int GBR_Status { get; set; }
        public int GBR_MDT_ID { get; set; }
    
        public virtual T_AP_Gebaeude T_AP_Gebaeude { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_AP_Standort T_AP_Standort { get; set; }
    }
}

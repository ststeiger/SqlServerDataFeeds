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
    
    public partial class T_SYS_Module
    {
        public T_SYS_Module()
        {
            this.T_SYS_Ref_Register = new HashSet<T_SYS_Ref_Register>();
            this.T_ZO_SYS_Module_AP_Ref_Mandant = new HashSet<T_ZO_SYS_Module_AP_Ref_Mandant>();
        }
    
        public System.Guid MOD_UID { get; set; }
        public string MOD_Code { get; set; }
        public string MOD_Modul { get; set; }
        public int MOD_Status { get; set; }
    
        public virtual ICollection<T_SYS_Ref_Register> T_SYS_Ref_Register { get; set; }
        public virtual ICollection<T_ZO_SYS_Module_AP_Ref_Mandant> T_ZO_SYS_Module_AP_Ref_Mandant { get; set; }
    }
}

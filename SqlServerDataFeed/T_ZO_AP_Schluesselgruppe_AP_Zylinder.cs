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
    
    public partial class T_ZO_AP_Schluesselgruppe_AP_Zylinder
    {
        public System.Guid ZO_SLGZYL_UID { get; set; }
        public int ZO_SLGZYL_Status { get; set; }
    
        public virtual T_AP_Schluesselgruppe T_AP_Schluesselgruppe { get; set; }
        public virtual T_AP_Zylinder T_AP_Zylinder { get; set; }
    }
}

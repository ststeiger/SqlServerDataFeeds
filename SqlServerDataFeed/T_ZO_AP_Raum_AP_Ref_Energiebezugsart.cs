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
    
    public partial class T_ZO_AP_Raum_AP_Ref_Energiebezugsart
    {
        public System.Guid ZO_RMEBA_UID { get; set; }
        public System.DateTime ZO_RMEBA_DatumVon { get; set; }
        public System.DateTime ZO_RMEBA_DatumBis { get; set; }
        public int ZO_RMEBA_Status { get; set; }
    
        public virtual T_AP_Raum T_AP_Raum { get; set; }
        public virtual T_AP_Ref_Energiebezugsart T_AP_Ref_Energiebezugsart { get; set; }
    }
}

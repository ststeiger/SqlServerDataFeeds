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
    
    public partial class T_ZO_AP_Raum_AP_Ref_Anmietvertraege
    {
        public System.Guid ZO_RMANVTR_UID { get; set; }
        public System.Guid ZO_RMANVTR_RM_UID { get; set; }
        public System.Guid ZO_RMANVTR_VTR_UID { get; set; }
        public System.DateTime ZO_RMANVTR_DatumVon { get; set; }
        public System.DateTime ZO_RMANVTR_DatumBis { get; set; }
        public int ZO_RMANVTR_Status { get; set; }
        public double ZO_RMANVTR_PreisM2 { get; set; }
        public double ZO_RMANVTR_Flaeche { get; set; }
        public string ZO_RMANVTR_Bemerkung { get; set; }
        public Nullable<double> ZO_RMANVTR_FlaecheProzent { get; set; }
    
        public virtual T_AP_Raum T_AP_Raum { get; set; }
        public virtual T_VM_Vertraege T_VM_Vertraege { get; set; }
    }
}

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
    
    public partial class T_ZO_AP_Raum_AP_Ref_Mietvertraege
    {
        public System.Guid ZO_RMVTR_UID { get; set; }
        public System.DateTime ZO_RMVTR_DatumVon { get; set; }
        public System.DateTime ZO_RMVTR_DatumBis { get; set; }
        public int ZO_RMVTR_Status { get; set; }
        public double ZO_RMVTR_PreisM2 { get; set; }
        public double ZO_RMVTR_Flaeche { get; set; }
        public string ZO_RMVTR_Bemerkung { get; set; }
        public Nullable<double> ZO_RMVTR_FlaecheProzent { get; set; }
    
        public virtual T_AP_Raum T_AP_Raum { get; set; }
        public virtual T_VM_Vertraege T_VM_Vertraege { get; set; }
    }
}

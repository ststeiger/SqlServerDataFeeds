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
    
    public partial class T_ZO_AP_Aussenobjekt_AP_Ref_Mietvertraege
    {
        public System.Guid ZO_AOVTR_UID { get; set; }
        public System.Guid ZO_AOVTR_AO_UID { get; set; }
        public System.Guid ZO_AOVTR_VTR_UID { get; set; }
        public System.DateTime ZO_AOVTR_DatumVon { get; set; }
        public System.DateTime ZO_AOVTR_DatumBis { get; set; }
        public int ZO_AOVTR_Status { get; set; }
        public double ZO_AOVTR_PreisM2 { get; set; }
        public double ZO_AOVTR_Flaeche { get; set; }
        public double ZO_AOVTR_Mietansatz { get; set; }
        public string ZO_AOVTR_Schild { get; set; }
        public string ZO_AOVTR_Bemerkung { get; set; }
        public Nullable<double> ZO_AOVTR_FlaecheProzent { get; set; }
    
        public virtual T_AP_Aussenobjekt T_AP_Aussenobjekt { get; set; }
        public virtual T_VM_Vertraege T_VM_Vertraege { get; set; }
    }
}

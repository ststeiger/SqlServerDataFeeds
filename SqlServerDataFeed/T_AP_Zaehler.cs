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
    
    public partial class T_AP_Zaehler
    {
        public T_AP_Zaehler()
        {
            this.T_ZO_AP_Zaehler_DWG = new HashSet<T_ZO_AP_Zaehler_DWG>();
        }
    
        public System.Guid ZL_UID { get; set; }
        public int ZL_MDT_ID { get; set; }
        public Nullable<System.Guid> ZL_RM_UID { get; set; }
        public Nullable<System.Guid> ZL_ZKAT_UID { get; set; }
        public string ZL_ApertureKey { get; set; }
        public string ZL_Nr { get; set; }
        public string ZL_Hersteller { get; set; }
        public string ZL_SerienNr { get; set; }
        public string ZL_Bemerkung { get; set; }
        public System.DateTime ZL_DatumVon { get; set; }
        public System.DateTime ZL_DatumBis { get; set; }
        public int ZL_Status { get; set; }
        public string ZL_Modell { get; set; }
        public string ZL_Typ { get; set; }
        public string ZL_TypenNr { get; set; }
        public Nullable<int> ZL_Baujahr { get; set; }
        public string ZL_Beschreibung { get; set; }
        public Nullable<System.Guid> ZL_ADR_UID { get; set; }
        public Nullable<System.Guid> ZL_BKP_UID { get; set; }
    
        public virtual T_AP_Raum T_AP_Raum { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_AV_Adressen T_AV_Adressen { get; set; }
        public virtual T_UPS_Ref_Baukostenplan T_UPS_Ref_Baukostenplan { get; set; }
        public virtual ICollection<T_ZO_AP_Zaehler_DWG> T_ZO_AP_Zaehler_DWG { get; set; }
    }
}

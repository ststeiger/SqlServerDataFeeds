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
    
    public partial class T_AP_Sicherheit
    {
        public T_AP_Sicherheit()
        {
            this.T_AP_Sicherheit_History = new HashSet<T_AP_Sicherheit_History>();
            this.T_SYS_Sicherheitrechte = new HashSet<T_SYS_Sicherheitrechte>();
            this.T_TM_Tasks_Planung = new HashSet<T_TM_Tasks_Planung>();
            this.T_TM_Tasks = new HashSet<T_TM_Tasks>();
            this.T_UPS_Rechnungskontrolle = new HashSet<T_UPS_Rechnungskontrolle>();
            this.T_ZO_AP_Sicherheit_DWG = new HashSet<T_ZO_AP_Sicherheit_DWG>();
        }
    
        public System.Guid SH_UID { get; set; }
        public Nullable<System.Guid> SH_SKAT_UID { get; set; }
        public string SH_ApertureKey { get; set; }
        public string SH_Nr { get; set; }
        public string SH_Hersteller { get; set; }
        public string SH_SerienNr { get; set; }
        public string SH_Bemerkung { get; set; }
        public System.DateTime SH_DatumVon { get; set; }
        public System.DateTime SH_DatumBis { get; set; }
        public int SH_Status { get; set; }
        public string SH_Modell { get; set; }
        public string SH_Typ { get; set; }
        public string SH_TypenNr { get; set; }
        public Nullable<int> SH_Baujahr { get; set; }
        public string SH_Beschreibung { get; set; }
    
        public virtual T_AP_Gebaeude T_AP_Gebaeude { get; set; }
        public virtual T_AP_Geschoss T_AP_Geschoss { get; set; }
        public virtual T_AP_Raum T_AP_Raum { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual ICollection<T_AP_Sicherheit_History> T_AP_Sicherheit_History { get; set; }
        public virtual T_AP_Standort T_AP_Standort { get; set; }
        public virtual T_AV_Adressen T_AV_Adressen { get; set; }
        public virtual T_UPS_Ref_Baukostenplan T_UPS_Ref_Baukostenplan { get; set; }
        public virtual ICollection<T_SYS_Sicherheitrechte> T_SYS_Sicherheitrechte { get; set; }
        public virtual ICollection<T_TM_Tasks_Planung> T_TM_Tasks_Planung { get; set; }
        public virtual ICollection<T_TM_Tasks> T_TM_Tasks { get; set; }
        public virtual ICollection<T_UPS_Rechnungskontrolle> T_UPS_Rechnungskontrolle { get; set; }
        public virtual ICollection<T_ZO_AP_Sicherheit_DWG> T_ZO_AP_Sicherheit_DWG { get; set; }
    }
}

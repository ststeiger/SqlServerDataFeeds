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
    
    public partial class T_AP_Zone
    {
        public T_AP_Zone()
        {
            this.T_AP_Zone_History = new HashSet<T_AP_Zone_History>();
            this.T_SYS_Zonerechte = new HashSet<T_SYS_Zonerechte>();
            this.T_TM_Tasks_Planung = new HashSet<T_TM_Tasks_Planung>();
            this.T_TM_Tasks = new HashSet<T_TM_Tasks>();
            this.T_ZO_AP_Zone_AP_Ref_Kostenstelle = new HashSet<T_ZO_AP_Zone_AP_Ref_Kostenstelle>();
            this.T_ZO_AP_Zone_AP_Ref_Mietobjekt = new HashSet<T_ZO_AP_Zone_AP_Ref_Mietobjekt>();
            this.T_ZO_AP_Zone_AP_Ref_Mietvertraege = new HashSet<T_ZO_AP_Zone_AP_Ref_Mietvertraege>();
            this.T_ZO_AP_Zone_AP_Ref_Organisationseinheit = new HashSet<T_ZO_AP_Zone_AP_Ref_Organisationseinheit>();
            this.T_ZO_AP_Zone_AP_Ref_Anmietvertraege = new HashSet<T_ZO_AP_Zone_AP_Ref_Anmietvertraege>();
            this.T_ZO_AP_Zone_DWG = new HashSet<T_ZO_AP_Zone_DWG>();
            this.T_ZO_AP_Zone_Flaeche = new HashSet<T_ZO_AP_Zone_Flaeche>();
        }
    
        public System.Guid ZN_UID { get; set; }
        public string ZN_ApertureKey { get; set; }
        public string ZN_Nr { get; set; }
        public string ZN_Bezeichnung { get; set; }
        public string ZN_Bemerkung { get; set; }
        public System.DateTime ZN_DatumVon { get; set; }
        public System.DateTime ZN_DatumBis { get; set; }
        public Nullable<int> ZN_Status { get; set; }
        public Nullable<System.DateTime> ZN_MutDate { get; set; }
        public string ZN_MutUser { get; set; }
    
        public virtual T_AP_Geschoss T_AP_Geschoss { get; set; }
        public virtual T_AP_Ref_Fluchtwegmarkierung T_AP_Ref_Fluchtwegmarkierung { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_AP_Ref_ZoneKategorie T_AP_Ref_ZoneKategorie { get; set; }
        public virtual T_AP_Trakt T_AP_Trakt { get; set; }
        public virtual ICollection<T_AP_Zone_History> T_AP_Zone_History { get; set; }
        public virtual T_VAR_Variante T_VAR_Variante { get; set; }
        public virtual ICollection<T_SYS_Zonerechte> T_SYS_Zonerechte { get; set; }
        public virtual ICollection<T_TM_Tasks_Planung> T_TM_Tasks_Planung { get; set; }
        public virtual ICollection<T_TM_Tasks> T_TM_Tasks { get; set; }
        public virtual ICollection<T_ZO_AP_Zone_AP_Ref_Kostenstelle> T_ZO_AP_Zone_AP_Ref_Kostenstelle { get; set; }
        public virtual ICollection<T_ZO_AP_Zone_AP_Ref_Mietobjekt> T_ZO_AP_Zone_AP_Ref_Mietobjekt { get; set; }
        public virtual ICollection<T_ZO_AP_Zone_AP_Ref_Mietvertraege> T_ZO_AP_Zone_AP_Ref_Mietvertraege { get; set; }
        public virtual ICollection<T_ZO_AP_Zone_AP_Ref_Organisationseinheit> T_ZO_AP_Zone_AP_Ref_Organisationseinheit { get; set; }
        public virtual ICollection<T_ZO_AP_Zone_AP_Ref_Anmietvertraege> T_ZO_AP_Zone_AP_Ref_Anmietvertraege { get; set; }
        public virtual ICollection<T_ZO_AP_Zone_DWG> T_ZO_AP_Zone_DWG { get; set; }
        public virtual ICollection<T_ZO_AP_Zone_Flaeche> T_ZO_AP_Zone_Flaeche { get; set; }
    }
}

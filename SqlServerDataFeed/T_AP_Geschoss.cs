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
    
    public partial class T_AP_Geschoss
    {
        public T_AP_Geschoss()
        {
            this.T_AP_Anlage = new HashSet<T_AP_Anlage>();
            this.T_AP_Geschoss_History = new HashSet<T_AP_Geschoss_History>();
            this.T_AP_Geschoss_Reichle = new HashSet<T_AP_Geschoss_Reichle>();
            this.T_AP_Parkplatz = new HashSet<T_AP_Parkplatz>();
            this.T_AP_Raum = new HashSet<T_AP_Raum>();
            this.T_AP_Sicherheit = new HashSet<T_AP_Sicherheit>();
            this.T_AP_Zone = new HashSet<T_AP_Zone>();
            this.T_SYS_Geschossrechte = new HashSet<T_SYS_Geschossrechte>();
            this.T_TM_Tasks_Planung = new HashSet<T_TM_Tasks_Planung>();
            this.T_TM_Tasks = new HashSet<T_TM_Tasks>();
            this.T_UM_Umzug = new HashSet<T_UM_Umzug>();
            this.T_ZO_AP_Geschoss_DWG = new HashSet<T_ZO_AP_Geschoss_DWG>();
            this.T_ZO_AP_Geschoss_Flaeche = new HashSet<T_ZO_AP_Geschoss_Flaeche>();
            this.T_ZO_AP_SHOW_Geschoss_Reinigungsplanung = new HashSet<T_ZO_AP_SHOW_Geschoss_Reinigungsplanung>();
        }
    
        public System.Guid GS_UID { get; set; }
        public int GS_MDT_ID { get; set; }
        public System.Guid GS_GB_UID { get; set; }
        public System.Guid GS_GST_UID { get; set; }
        public string GS_ApertureKey { get; set; }
        public string GS_Nr { get; set; }
        public string GS_Bezeichnung { get; set; }
        public double GS_Hoehe { get; set; }
        public int GS_Sort { get; set; }
        public bool GS_IsAussengeschoss { get; set; }
        public string GS_Bemerkung { get; set; }
        public System.DateTime GS_DatumVon { get; set; }
        public System.DateTime GS_DatumBis { get; set; }
        public int GS_Status { get; set; }
        public Nullable<System.DateTime> GS_MutDate { get; set; }
        public string GS_MutUser { get; set; }
        public string GS_Sammelplatz { get; set; }
        public string C_Ueberbauung_Nr { get; set; }
        public string C_Gebaeude_Nr { get; set; }
        public string C_Gebaeude_Name { get; set; }
        public string C_Liegenschaft_Nr { get; set; }
        public string C_Geschoss { get; set; }
        public string GS_CAD_Name { get; set; }
        public string GS_Planseite { get; set; }
    
        public virtual ICollection<T_AP_Anlage> T_AP_Anlage { get; set; }
        public virtual T_AP_Gebaeude T_AP_Gebaeude { get; set; }
        public virtual ICollection<T_AP_Geschoss_History> T_AP_Geschoss_History { get; set; }
        public virtual ICollection<T_AP_Geschoss_Reichle> T_AP_Geschoss_Reichle { get; set; }
        public virtual T_AP_Ref_Geschosstyp T_AP_Ref_Geschosstyp { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual ICollection<T_AP_Parkplatz> T_AP_Parkplatz { get; set; }
        public virtual ICollection<T_AP_Raum> T_AP_Raum { get; set; }
        public virtual ICollection<T_AP_Sicherheit> T_AP_Sicherheit { get; set; }
        public virtual ICollection<T_AP_Zone> T_AP_Zone { get; set; }
        public virtual ICollection<T_SYS_Geschossrechte> T_SYS_Geschossrechte { get; set; }
        public virtual ICollection<T_TM_Tasks_Planung> T_TM_Tasks_Planung { get; set; }
        public virtual ICollection<T_TM_Tasks> T_TM_Tasks { get; set; }
        public virtual ICollection<T_UM_Umzug> T_UM_Umzug { get; set; }
        public virtual ICollection<T_ZO_AP_Geschoss_DWG> T_ZO_AP_Geschoss_DWG { get; set; }
        public virtual ICollection<T_ZO_AP_Geschoss_Flaeche> T_ZO_AP_Geschoss_Flaeche { get; set; }
        public virtual ICollection<T_ZO_AP_SHOW_Geschoss_Reinigungsplanung> T_ZO_AP_SHOW_Geschoss_Reinigungsplanung { get; set; }
    }
}

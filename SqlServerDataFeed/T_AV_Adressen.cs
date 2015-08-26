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
    
    public partial class T_AV_Adressen
    {
        public T_AV_Adressen()
        {
            this.T_AP_Anlage = new HashSet<T_AP_Anlage>();
            this.T_AP_Aussenobjekt = new HashSet<T_AP_Aussenobjekt>();
            this.T_AP_Gebaeude = new HashSet<T_AP_Gebaeude>();
            this.T_AP_Informatik = new HashSet<T_AP_Informatik>();
            this.T_AP_Kommunikation = new HashSet<T_AP_Kommunikation>();
            this.T_AP_Mobiliar = new HashSet<T_AP_Mobiliar>();
            this.T_AP_Schluessel = new HashSet<T_AP_Schluessel>();
            this.T_AP_Sicherheit = new HashSet<T_AP_Sicherheit>();
            this.T_AP_Zaehler = new HashSet<T_AP_Zaehler>();
            this.T_AV_AdresseKontaktpersonen = new HashSet<T_AV_AdresseKontaktpersonen>();
            this.T_AV_Adressen_History = new HashSet<T_AV_Adressen_History>();
            this.T_TM_Tasks_Planung = new HashSet<T_TM_Tasks_Planung>();
            this.T_TM_Tasks_Planung1 = new HashSet<T_TM_Tasks_Planung>();
            this.T_TM_Tasks = new HashSet<T_TM_Tasks>();
            this.T_TM_Tasks1 = new HashSet<T_TM_Tasks>();
            this.T_UPS_Rechnungskontrolle = new HashSet<T_UPS_Rechnungskontrolle>();
            this.T_VM_Vertraege = new HashSet<T_VM_Vertraege>();
            this.T_ZO_AP_Aussenobjekt_AP_Belegung = new HashSet<T_ZO_AP_Aussenobjekt_AP_Belegung>();
            this.T_ZO_AP_Parkplatz_AP_Belegung = new HashSet<T_ZO_AP_Parkplatz_AP_Belegung>();
            this.T_ZO_AP_Parkplatz_AV_Adressen = new HashSet<T_ZO_AP_Parkplatz_AV_Adressen>();
            this.T_ZO_AV_Adresse_AV_Ref_AdresseRollen = new HashSet<T_ZO_AV_Adresse_AV_Ref_AdresseRollen>();
        }
    
        public System.Guid ADR_UID { get; set; }
        public int ADR_MDT_ID { get; set; }
        public Nullable<System.Guid> ADR_AA_UID { get; set; }
        public Nullable<System.Guid> ADR_LD_UID { get; set; }
        public string ADR_Nr { get; set; }
        public string ADR_Name { get; set; }
        public string ADR_Vorname { get; set; }
        public string ADR_Strasse { get; set; }
        public string ADR_PLZ { get; set; }
        public string ADR_Ort { get; set; }
        public string ADR_Land { get; set; }
        public Nullable<System.Guid> ADR_RG_UID { get; set; }
        public string ADR_Tel { get; set; }
        public string ADR_Tel2 { get; set; }
        public string ADR_Mobile { get; set; }
        public string ADR_Fax { get; set; }
        public string ADR_Email { get; set; }
        public string ADR_Homepage { get; set; }
        public string ADR_Bemerkung { get; set; }
        public int ADR_Status { get; set; }
        public string ADR_MWSt { get; set; }
        public Nullable<System.DateTime> ADR_DatumVon { get; set; }
        public Nullable<System.DateTime> ADR_DatumBis { get; set; }
        public Nullable<int> ADR_StylizerFore { get; set; }
        public Nullable<int> ADR_StylizerBack { get; set; }
        public Nullable<int> ADR_StylizerPattern { get; set; }
        public Nullable<int> ADR_StylizerLine { get; set; }
        public string ADR_Suchbegriff { get; set; }
        public Nullable<System.Guid> ADR_ARE_UID { get; set; }
    
        public virtual ICollection<T_AP_Anlage> T_AP_Anlage { get; set; }
        public virtual ICollection<T_AP_Aussenobjekt> T_AP_Aussenobjekt { get; set; }
        public virtual ICollection<T_AP_Gebaeude> T_AP_Gebaeude { get; set; }
        public virtual ICollection<T_AP_Informatik> T_AP_Informatik { get; set; }
        public virtual ICollection<T_AP_Kommunikation> T_AP_Kommunikation { get; set; }
        public virtual ICollection<T_AP_Mobiliar> T_AP_Mobiliar { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_AP_Ref_Region T_AP_Ref_Region { get; set; }
        public virtual ICollection<T_AP_Schluessel> T_AP_Schluessel { get; set; }
        public virtual ICollection<T_AP_Sicherheit> T_AP_Sicherheit { get; set; }
        public virtual ICollection<T_AP_Zaehler> T_AP_Zaehler { get; set; }
        public virtual ICollection<T_AV_AdresseKontaktpersonen> T_AV_AdresseKontaktpersonen { get; set; }
        public virtual ICollection<T_AV_Adressen_History> T_AV_Adressen_History { get; set; }
        public virtual T_AV_Ref_Region T_AV_Ref_Region { get; set; }
        public virtual ICollection<T_TM_Tasks_Planung> T_TM_Tasks_Planung { get; set; }
        public virtual ICollection<T_TM_Tasks_Planung> T_TM_Tasks_Planung1 { get; set; }
        public virtual ICollection<T_TM_Tasks> T_TM_Tasks { get; set; }
        public virtual ICollection<T_TM_Tasks> T_TM_Tasks1 { get; set; }
        public virtual ICollection<T_UPS_Rechnungskontrolle> T_UPS_Rechnungskontrolle { get; set; }
        public virtual ICollection<T_VM_Vertraege> T_VM_Vertraege { get; set; }
        public virtual ICollection<T_ZO_AP_Aussenobjekt_AP_Belegung> T_ZO_AP_Aussenobjekt_AP_Belegung { get; set; }
        public virtual ICollection<T_ZO_AP_Parkplatz_AP_Belegung> T_ZO_AP_Parkplatz_AP_Belegung { get; set; }
        public virtual ICollection<T_ZO_AP_Parkplatz_AV_Adressen> T_ZO_AP_Parkplatz_AV_Adressen { get; set; }
        public virtual ICollection<T_ZO_AV_Adresse_AV_Ref_AdresseRollen> T_ZO_AV_Adresse_AV_Ref_AdresseRollen { get; set; }
    }
}

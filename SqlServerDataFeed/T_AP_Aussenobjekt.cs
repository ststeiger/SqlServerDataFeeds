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
    
    public partial class T_AP_Aussenobjekt
    {
        public T_AP_Aussenobjekt()
        {
            this.T_AP_Aussenobjekt_History = new HashSet<T_AP_Aussenobjekt_History>();
            this.T_SYS_Aussenobjektrechte = new HashSet<T_SYS_Aussenobjektrechte>();
            this.T_TM_Tasks_Planung = new HashSet<T_TM_Tasks_Planung>();
            this.T_TM_Tasks = new HashSet<T_TM_Tasks>();
            this.T_ZO_AP_Aussenobjekt_AP_Belegung = new HashSet<T_ZO_AP_Aussenobjekt_AP_Belegung>();
            this.T_ZO_AP_Aussenobjekt_AP_Ref_AussenobjektAusbauten = new HashSet<T_ZO_AP_Aussenobjekt_AP_Ref_AussenobjektAusbauten>();
            this.T_ZO_AP_Aussenobjekt_AP_Ref_Kostenstelle = new HashSet<T_ZO_AP_Aussenobjekt_AP_Ref_Kostenstelle>();
            this.T_ZO_AP_Aussenobjekt_AP_Ref_Mietobjekt = new HashSet<T_ZO_AP_Aussenobjekt_AP_Ref_Mietobjekt>();
            this.T_ZO_AP_Aussenobjekt_AP_Ref_Mietvertraege = new HashSet<T_ZO_AP_Aussenobjekt_AP_Ref_Mietvertraege>();
            this.T_ZO_AP_Aussenobjekt_AP_Ref_Anmietvertraege = new HashSet<T_ZO_AP_Aussenobjekt_AP_Ref_Anmietvertraege>();
            this.T_ZO_AP_Aussenobjekt_DWG = new HashSet<T_ZO_AP_Aussenobjekt_DWG>();
            this.T_ZO_AP_Aussenobjekt_Flaeche = new HashSet<T_ZO_AP_Aussenobjekt_Flaeche>();
        }
    
        public System.Guid AO_UID { get; set; }
        public string AO_ApertureKey { get; set; }
        public string AO_Nr { get; set; }
        public string AO_Bezeichnung { get; set; }
        public int AO_Beflaggung_Anzahl { get; set; }
        public string AO_Brunnen_WVNr { get; set; }
        public bool AO_Brunnen_IsDenkmalschutz { get; set; }
        public string AO_Strasse { get; set; }
        public string AO_Strasse_Nr { get; set; }
        public string AO_Bemerkung { get; set; }
        public System.DateTime AO_DatumVon { get; set; }
        public System.DateTime AO_DatumBis { get; set; }
        public int AO_Status { get; set; }
        public string AO_PLZ { get; set; }
        public string AO_Ort { get; set; }
    
        public virtual ICollection<T_AP_Aussenobjekt_History> T_AP_Aussenobjekt_History { get; set; }
        public virtual T_AP_Grundstueck T_AP_Grundstueck { get; set; }
        public virtual T_AP_Ref_AussenobjektAnschlagkastenMaterial T_AP_Ref_AussenobjektAnschlagkastenMaterial { get; set; }
        public virtual T_AP_Ref_AussenobjektAnschlagkastenSchliessung T_AP_Ref_AussenobjektAnschlagkastenSchliessung { get; set; }
        public virtual T_AP_Ref_AussenobjektAnschlagkastenTyp T_AP_Ref_AussenobjektAnschlagkastenTyp { get; set; }
        public virtual T_AP_Ref_AussenobjektBeflaggungTyp T_AP_Ref_AussenobjektBeflaggungTyp { get; set; }
        public virtual T_AP_Ref_AussenobjektBodenbelag T_AP_Ref_AussenobjektBodenbelag { get; set; }
        public virtual T_AP_Ref_AussenobjektKategorie T_AP_Ref_AussenobjektKategorie { get; set; }
        public virtual T_AP_Ref_AussenobjektNutzungsart T_AP_Ref_AussenobjektNutzungsart { get; set; }
        public virtual T_AP_Ref_Haus T_AP_Ref_Haus { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_AP_Standort T_AP_Standort { get; set; }
        public virtual T_AV_Adressen T_AV_Adressen { get; set; }
        public virtual ICollection<T_SYS_Aussenobjektrechte> T_SYS_Aussenobjektrechte { get; set; }
        public virtual ICollection<T_TM_Tasks_Planung> T_TM_Tasks_Planung { get; set; }
        public virtual ICollection<T_TM_Tasks> T_TM_Tasks { get; set; }
        public virtual ICollection<T_ZO_AP_Aussenobjekt_AP_Belegung> T_ZO_AP_Aussenobjekt_AP_Belegung { get; set; }
        public virtual ICollection<T_ZO_AP_Aussenobjekt_AP_Ref_AussenobjektAusbauten> T_ZO_AP_Aussenobjekt_AP_Ref_AussenobjektAusbauten { get; set; }
        public virtual ICollection<T_ZO_AP_Aussenobjekt_AP_Ref_Kostenstelle> T_ZO_AP_Aussenobjekt_AP_Ref_Kostenstelle { get; set; }
        public virtual ICollection<T_ZO_AP_Aussenobjekt_AP_Ref_Mietobjekt> T_ZO_AP_Aussenobjekt_AP_Ref_Mietobjekt { get; set; }
        public virtual ICollection<T_ZO_AP_Aussenobjekt_AP_Ref_Mietvertraege> T_ZO_AP_Aussenobjekt_AP_Ref_Mietvertraege { get; set; }
        public virtual ICollection<T_ZO_AP_Aussenobjekt_AP_Ref_Anmietvertraege> T_ZO_AP_Aussenobjekt_AP_Ref_Anmietvertraege { get; set; }
        public virtual ICollection<T_ZO_AP_Aussenobjekt_DWG> T_ZO_AP_Aussenobjekt_DWG { get; set; }
        public virtual ICollection<T_ZO_AP_Aussenobjekt_Flaeche> T_ZO_AP_Aussenobjekt_Flaeche { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SqlServerDataFeed
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_AP_Gebaeude
    {
        public T_AP_Gebaeude()
        {
            this.T_AP_Anlage = new HashSet<T_AP_Anlage>();
            this.T_AP_Fahrzeug = new HashSet<T_AP_Fahrzeug>();
            this.T_AP_Gebaeude_History = new HashSet<T_AP_Gebaeude_History>();
            this.T_AP_Gebaeude_Reichle = new HashSet<T_AP_Gebaeude_Reichle>();
            this.T_AP_Gebaeude_SwissLife = new HashSet<T_AP_Gebaeude_SwissLife>();
            this.T_AP_Geschoss = new HashSet<T_AP_Geschoss>();
            this.T_AP_Sicherheit = new HashSet<T_AP_Sicherheit>();
            this.T_AP_Trakt = new HashSet<T_AP_Trakt>();
            this.T_ZO_REM_AP_Gebaeude_Ref_Raumpfleger = new HashSet<T_ZO_REM_AP_Gebaeude_Ref_Raumpfleger>();
            this.T_SYS_Gebaeuderechte = new HashSet<T_SYS_Gebaeuderechte>();
            this.T_SYS_Geschossrechte = new HashSet<T_SYS_Geschossrechte>();
            this.T_TM_Tasks_Planung = new HashSet<T_TM_Tasks_Planung>();
            this.T_TM_Tasks = new HashSet<T_TM_Tasks>();
            this.T_UM_Umzug = new HashSet<T_UM_Umzug>();
            this.T_UPS_Rechnungskontrolle = new HashSet<T_UPS_Rechnungskontrolle>();
            this.T_UW_Verbrauch = new HashSet<T_UW_Verbrauch>();
            this.T_ZO_AP_Gebaeude_AP_Ref_AnlagaeKategorieSchema = new HashSet<T_ZO_AP_Gebaeude_AP_Ref_AnlagaeKategorieSchema>();
            this.T_ZO_AP_Gebaeude_DWG = new HashSet<T_ZO_AP_Gebaeude_DWG>();
            this.T_ZO_AP_Gebaeude_Flaeche = new HashSet<T_ZO_AP_Gebaeude_Flaeche>();
        }
    
        public System.Guid GB_UID { get; set; }
        public int GB_MDT_ID { get; set; }
        public System.Guid GB_SO_UID { get; set; }
        public Nullable<System.Guid> GB_EV_UID { get; set; }
        public Nullable<System.Guid> GB_GK_UID { get; set; }
        public string GB_ApertureKey { get; set; }
        public string GB_Nr { get; set; }
        public string GB_Strasse { get; set; }
        public string GB_StrasseNr { get; set; }
        public string GB_PLZ { get; set; }
        public string GB_Ort { get; set; }
        public string GB_Bezeichnung { get; set; }
        public string GB_Bemerkung { get; set; }
        public string GB_DETAIL_AssekuranzNr { get; set; }
        public string GB_DETAIL_AssekuranzPoliceNr { get; set; }
        public Nullable<double> GB_DETAIL_Assekuranzwert { get; set; }
        public Nullable<int> GB_DETAIL_Baujahr { get; set; }
        public string GB_DETAIL_Bauzone { get; set; }
        public Nullable<double> GB_DETAIL_Buchwert { get; set; }
        public string GB_DETAIL_EntsorgungsamtKundenNr { get; set; }
        public Nullable<System.Guid> GB_DETAIL_ERF_UID { get; set; }
        public Nullable<System.Guid> GB_DETAIL_ERS_UID { get; set; }
        public Nullable<double> GB_DETAIL_Ertragswert { get; set; }
        public Nullable<int> GB_DETAIL_Erwerbsjahr { get; set; }
        public Nullable<System.Guid> GB_DETAIL_GES_UID { get; set; }
        public string GB_DETAIL_GewSchutzzone { get; set; }
        public bool GB_DETAIL_IsSchutzraumpflicht { get; set; }
        public string GB_DETAIL_GrundstückNr { get; set; }
        public Nullable<double> GB_DETAIL_GrundstueckFlaeche { get; set; }
        public Nullable<double> GB_DETAIL_Landwert { get; set; }
        public Nullable<System.DateTime> GB_DETAIL_LetzteRenovation { get; set; }
        public Nullable<System.DateTime> GB_DETAIL_LetzteSanierung { get; set; }
        public Nullable<System.Guid> GB_DETAIL_LS_UID { get; set; }
        public Nullable<double> GB_DETAIL_Realwert { get; set; }
        public string GB_DETAIL_SpezReVerhaeltnisse { get; set; }
        public string GB_DETAIL_Umnutzung { get; set; }
        public Nullable<double> GB_DETAIL_Verkehrswert { get; set; }
        public Nullable<System.Guid> GB_DETAIL_ZZT_UID { get; set; }
        public System.DateTime GB_DatumVon { get; set; }
        public System.DateTime GB_DatumBis { get; set; }
        public int GB_Status { get; set; }
        public Nullable<System.DateTime> GB_MutDate { get; set; }
        public string GB_MutUser { get; set; }
        public Nullable<System.Guid> GB_ADR_UID { get; set; }
        public Nullable<System.Guid> GB_SK_UID { get; set; }
        public Nullable<double> GB_Lage_Faktor { get; set; }
        public Nullable<double> GB_Nebenkosten { get; set; }
        public string GB_Kundennummer { get; set; }
        public string GB_Eigentuemer { get; set; }
        public string GB_Versicherungsnummer { get; set; }
        public string GB_Gemeinde { get; set; }
        public string GB_Standort { get; set; }
        public string GB_Gebaeudeklasse { get; set; }
        public string GB_Gefahrenklasse { get; set; }
        public string GB_letzte_Schaetzung { get; set; }
        public Nullable<double> GB_Neuwert { get; set; }
        public Nullable<double> GB_Zeitwert { get; set; }
        public Nullable<double> GB_Raum_SIA_116 { get; set; }
        public string GB_Koordinaten { get; set; }
        public Nullable<double> GB_DETAIL_KubischeFlaeche { get; set; }
        public string GB_Code { get; set; }
        public string GB_Adresszusatz { get; set; }
        public string GB_EGID { get; set; }
        public string GB_Sammelplatz { get; set; }
        public Nullable<System.Guid> GB_KL_UID { get; set; }
        public Nullable<decimal> GB_GM_Lat { get; set; }
        public Nullable<decimal> GB_GM_Lng { get; set; }
        public Nullable<decimal> GB_GM_SVLat { get; set; }
        public Nullable<decimal> GB_GM_SVLng { get; set; }
    
        public virtual ICollection<T_AP_Anlage> T_AP_Anlage { get; set; }
        public virtual ICollection<T_AP_Fahrzeug> T_AP_Fahrzeug { get; set; }
        public virtual ICollection<T_AP_Gebaeude_History> T_AP_Gebaeude_History { get; set; }
        public virtual ICollection<T_AP_Gebaeude_Reichle> T_AP_Gebaeude_Reichle { get; set; }
        public virtual ICollection<T_AP_Gebaeude_SwissLife> T_AP_Gebaeude_SwissLife { get; set; }
        public virtual T_AP_Ref_Eigentumsverhaeltnis T_AP_Ref_Eigentumsverhaeltnis { get; set; }
        public virtual T_AP_Ref_ErschliessungFussweg T_AP_Ref_ErschliessungFussweg { get; set; }
        public virtual T_AP_Ref_ErschliessungStrasse T_AP_Ref_ErschliessungStrasse { get; set; }
        public virtual T_AP_Ref_GebaeudeEinstufung T_AP_Ref_GebaeudeEinstufung { get; set; }
        public virtual T_AP_Ref_GebaeudeKategorie T_AP_Ref_GebaeudeKategorie { get; set; }
        public virtual T_AP_Ref_GebaeudeKlassifizierung T_AP_Ref_GebaeudeKlassifizierung { get; set; }
        public virtual T_AP_Ref_LiegenschaftenStrategie T_AP_Ref_LiegenschaftenStrategie { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_AP_Ref_StandortKategorie T_AP_Ref_StandortKategorie { get; set; }
        public virtual T_AP_Ref_Zonenzuteilung T_AP_Ref_Zonenzuteilung { get; set; }
        public virtual T_AP_Standort T_AP_Standort { get; set; }
        public virtual T_AV_Adressen T_AV_Adressen { get; set; }
        public virtual ICollection<T_AP_Geschoss> T_AP_Geschoss { get; set; }
        public virtual ICollection<T_AP_Sicherheit> T_AP_Sicherheit { get; set; }
        public virtual ICollection<T_AP_Trakt> T_AP_Trakt { get; set; }
        public virtual ICollection<T_ZO_REM_AP_Gebaeude_Ref_Raumpfleger> T_ZO_REM_AP_Gebaeude_Ref_Raumpfleger { get; set; }
        public virtual ICollection<T_SYS_Gebaeuderechte> T_SYS_Gebaeuderechte { get; set; }
        public virtual ICollection<T_SYS_Geschossrechte> T_SYS_Geschossrechte { get; set; }
        public virtual ICollection<T_TM_Tasks_Planung> T_TM_Tasks_Planung { get; set; }
        public virtual ICollection<T_TM_Tasks> T_TM_Tasks { get; set; }
        public virtual ICollection<T_UM_Umzug> T_UM_Umzug { get; set; }
        public virtual ICollection<T_UPS_Rechnungskontrolle> T_UPS_Rechnungskontrolle { get; set; }
        public virtual ICollection<T_UW_Verbrauch> T_UW_Verbrauch { get; set; }
        public virtual ICollection<T_ZO_AP_Gebaeude_AP_Ref_AnlagaeKategorieSchema> T_ZO_AP_Gebaeude_AP_Ref_AnlagaeKategorieSchema { get; set; }
        public virtual ICollection<T_ZO_AP_Gebaeude_DWG> T_ZO_AP_Gebaeude_DWG { get; set; }
        public virtual ICollection<T_ZO_AP_Gebaeude_Flaeche> T_ZO_AP_Gebaeude_Flaeche { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SqlServerDataFeedEF6
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_AP_Kontakte
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Kontakte()
        {
            this.T_AP_Kontakte_History = new HashSet<T_AP_Kontakte_History>();
            this.T_AP_Schluessel = new HashSet<T_AP_Schluessel>();
            this.T_MM_Umzug = new HashSet<T_MM_Umzug>();
            this.T_ZO_REM_AP_Gebaeude_Ref_Raumpfleger = new HashSet<T_ZO_REM_AP_Gebaeude_Ref_Raumpfleger>();
            this.T_TM_Tasks_Planung = new HashSet<T_TM_Tasks_Planung>();
            this.T_TM_Tasks = new HashSet<T_TM_Tasks>();
            this.T_UM_Planung = new HashSet<T_UM_Planung>();
            this.T_UM_Planung1 = new HashSet<T_UM_Planung>();
            this.T_UM_Umzug = new HashSet<T_UM_Umzug>();
            this.T_ZO_AP_Arbeitsplatz_AP_Belegung = new HashSet<T_ZO_AP_Arbeitsplatz_AP_Belegung>();
            this.T_ZO_AP_Aussenobjekt_AP_Belegung = new HashSet<T_ZO_AP_Aussenobjekt_AP_Belegung>();
            this.T_ZO_AP_Kontakte_AP_Ref_Funktionen = new HashSet<T_ZO_AP_Kontakte_AP_Ref_Funktionen>();
            this.T_ZO_AP_Kontakte_AP_Ref_Kostenstelle = new HashSet<T_ZO_AP_Kontakte_AP_Ref_Kostenstelle>();
            this.T_ZO_AP_Kontakte_AP_Ref_MitarbeiterAusruestung = new HashSet<T_ZO_AP_Kontakte_AP_Ref_MitarbeiterAusruestung>();
            this.T_ZO_AP_Kontakte_AP_Ref_Organisationseinheit = new HashSet<T_ZO_AP_Kontakte_AP_Ref_Organisationseinheit>();
            this.T_ZO_AP_Kontakte_AP_Ref_PersonalKategorie = new HashSet<T_ZO_AP_Kontakte_AP_Ref_PersonalKategorie>();
            this.T_ZO_AP_Objekt_AP_Kontakte = new HashSet<T_ZO_AP_Objekt_AP_Kontakte>();
            this.T_ZO_AP_Parkplatz_AP_Belegung = new HashSet<T_ZO_AP_Parkplatz_AP_Belegung>();
            this.T_ZO_AP_Parkplatz_AP_Kontakte = new HashSet<T_ZO_AP_Parkplatz_AP_Kontakte>();
            this.T_ZO_AP_Schluessel_AP_Kontakte = new HashSet<T_ZO_AP_Schluessel_AP_Kontakte>();
        }
    
        public System.Guid KT_UID { get; set; }
        public int KT_MDT_ID { get; set; }
        public Nullable<System.Guid> KT_KOE_UID { get; set; }
        public Nullable<System.Guid> KT_KST_UID { get; set; }
        public Nullable<System.Guid> KT_KG_UID { get; set; }
        public Nullable<System.Guid> KT_PK_UID { get; set; }
        public string KT_Nummer { get; set; }
        public string KT_Name { get; set; }
        public string KT_Vorname { get; set; }
        public string KT_Tel { get; set; }
        public string KT_Mobile { get; set; }
        public string KT_eMail { get; set; }
        public int KT_Status { get; set; }
        public int KT_Sort { get; set; }
        public bool KT_IsDefault { get; set; }
        public string KT_KZ { get; set; }
        public string KT_Login { get; set; }
        public string KT_Tel2 { get; set; }
        public string KT_Tel3 { get; set; }
        public string KT_Tel4 { get; set; }
        public string KT_Tel5 { get; set; }
        public string KT_Tel2Bem { get; set; }
        public string KT_Tel3Bem { get; set; }
        public string KT_Tel4Bem { get; set; }
        public string KT_Tel5Bem { get; set; }
        public System.DateTime KT_DatumVon { get; set; }
        public System.DateTime KT_DatumBis { get; set; }
        public string KT_Bemerkung { get; set; }
        public Nullable<bool> KT_IsFromOdis { get; set; }
        public Nullable<double> KT_Beschaeftigungsgrad { get; set; }
        public string KT_Vertragsart { get; set; }
        public string KT_Hierarchie { get; set; }
        public string KT_Arbeitsgeber { get; set; }
        public string KT_Funktionsstufe { get; set; }
        public string KT_AHV_Nummer { get; set; }
        public Nullable<System.Guid> KT_MS_UID { get; set; }
        public string KT_Strasse { get; set; }
        public string KT_Adresszusatz { get; set; }
        public string KT_PLZ { get; set; }
        public string KT_Ort { get; set; }
        public Nullable<System.DateTime> KT_DatumAustritt { get; set; }
        public string KT_Funktion_Kurz { get; set; }
        public string KT_Funktion_Lang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Kontakte_History> T_AP_Kontakte_History { get; set; }
        public virtual T_AP_Ref_Organisationseinheit T_AP_Ref_Organisationseinheit { get; set; }
        public virtual T_AP_Ref_KontaktGeschlecht T_AP_Ref_KontaktGeschlecht { get; set; }
        public virtual T_AP_Ref_Kostenstelle T_AP_Ref_Kostenstelle { get; set; }
        public virtual T_AP_Ref_MitarbeiterStatus T_AP_Ref_MitarbeiterStatus { get; set; }
        public virtual T_AP_Ref_PersonalKategorie T_AP_Ref_PersonalKategorie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Schluessel> T_AP_Schluessel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_MM_Umzug> T_MM_Umzug { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_REM_AP_Gebaeude_Ref_Raumpfleger> T_ZO_REM_AP_Gebaeude_Ref_Raumpfleger { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TM_Tasks_Planung> T_TM_Tasks_Planung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TM_Tasks> T_TM_Tasks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_UM_Planung> T_UM_Planung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_UM_Planung> T_UM_Planung1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_UM_Umzug> T_UM_Umzug { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Arbeitsplatz_AP_Belegung> T_ZO_AP_Arbeitsplatz_AP_Belegung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Aussenobjekt_AP_Belegung> T_ZO_AP_Aussenobjekt_AP_Belegung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Kontakte_AP_Ref_Funktionen> T_ZO_AP_Kontakte_AP_Ref_Funktionen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Kontakte_AP_Ref_Kostenstelle> T_ZO_AP_Kontakte_AP_Ref_Kostenstelle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Kontakte_AP_Ref_MitarbeiterAusruestung> T_ZO_AP_Kontakte_AP_Ref_MitarbeiterAusruestung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Kontakte_AP_Ref_Organisationseinheit> T_ZO_AP_Kontakte_AP_Ref_Organisationseinheit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Kontakte_AP_Ref_PersonalKategorie> T_ZO_AP_Kontakte_AP_Ref_PersonalKategorie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Objekt_AP_Kontakte> T_ZO_AP_Objekt_AP_Kontakte { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Parkplatz_AP_Belegung> T_ZO_AP_Parkplatz_AP_Belegung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Parkplatz_AP_Kontakte> T_ZO_AP_Parkplatz_AP_Kontakte { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Schluessel_AP_Kontakte> T_ZO_AP_Schluessel_AP_Kontakte { get; set; }
    }
}

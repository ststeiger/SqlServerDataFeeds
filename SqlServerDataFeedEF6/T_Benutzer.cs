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
    
    public partial class T_Benutzer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Benutzer()
        {
            this.T_AP_Dokumente = new HashSet<T_AP_Dokumente>();
            this.T_AP_Dokumente_Log = new HashSet<T_AP_Dokumente_Log>();
            this.T_Benutzer_Benutzergruppen = new HashSet<T_Benutzer_Benutzergruppen>();
            this.T_FMS_ZO_Navigation_Benutzer = new HashSet<T_FMS_ZO_Navigation_Benutzer>();
            this.T_FMS_ZO_Navigation = new HashSet<T_FMS_ZO_Navigation>();
            this.T_SYS_Ref_Version = new HashSet<T_SYS_Ref_Version>();
            this.T_TM_Tasks_Planung = new HashSet<T_TM_Tasks_Planung>();
            this.T_TM_Tasks_Planung1 = new HashSet<T_TM_Tasks_Planung>();
            this.T_TM_Tasks = new HashSet<T_TM_Tasks>();
            this.T_TM_Tasks1 = new HashSet<T_TM_Tasks>();
            this.T_UPS_Rechnungskontrolle = new HashSet<T_UPS_Rechnungskontrolle>();
            this.T_ZO_AP_Arbeitsplatz_Reservation = new HashSet<T_ZO_AP_Arbeitsplatz_Reservation>();
            this.T_ZO_AP_MarkDWG = new HashSet<T_ZO_AP_MarkDWG>();
            this.T_ZO_AP_Parkplatz_Reservation = new HashSet<T_ZO_AP_Parkplatz_Reservation>();
            this.T_ZO_AP_Raum_Reservation = new HashSet<T_ZO_AP_Raum_Reservation>();
            this.T_ZO_AP_Zylinder_AP_Schluesselgruppe_Benutzer = new HashSet<T_ZO_AP_Zylinder_AP_Schluesselgruppe_Benutzer>();
            this.T_ZO_SYS_Settings_Benutzer = new HashSet<T_ZO_SYS_Settings_Benutzer>();
            this.T_AP_Ref_Mandant = new HashSet<T_AP_Ref_Mandant>();
        }
    
        public int BE_ID { get; set; }
        public string BE_Name { get; set; }
        public string BE_Vorname { get; set; }
        public string BE_User { get; set; }
        public string BE_Passwort { get; set; }
        public string BE_Language { get; set; }
        public string BE_Hash { get; set; }
        public byte BE_Level { get; set; }
        public bool BE_isLDAPSync { get; set; }
        public string BE_Domaene { get; set; }
        public Nullable<bool> BE_Hide { get; set; }
        public string BE_Email { get; set; }
        public string BE_TelNr { get; set; }
        public Nullable<int> BE_CurrencyID { get; set; }
        public Nullable<int> BE_Status { get; set; }
        public string BE_IsCOR_Hash { get; set; }
        public bool BE_IsGuest { get; set; }
        public Nullable<int> BE_Augen { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Dokumente> T_AP_Dokumente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Dokumente_Log> T_AP_Dokumente_Log { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Benutzer_Benutzergruppen> T_Benutzer_Benutzergruppen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_FMS_ZO_Navigation_Benutzer> T_FMS_ZO_Navigation_Benutzer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_FMS_ZO_Navigation> T_FMS_ZO_Navigation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_SYS_Ref_Version> T_SYS_Ref_Version { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TM_Tasks_Planung> T_TM_Tasks_Planung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TM_Tasks_Planung> T_TM_Tasks_Planung1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TM_Tasks> T_TM_Tasks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TM_Tasks> T_TM_Tasks1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_UPS_Rechnungskontrolle> T_UPS_Rechnungskontrolle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Arbeitsplatz_Reservation> T_ZO_AP_Arbeitsplatz_Reservation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_MarkDWG> T_ZO_AP_MarkDWG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Parkplatz_Reservation> T_ZO_AP_Parkplatz_Reservation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Raum_Reservation> T_ZO_AP_Raum_Reservation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Zylinder_AP_Schluesselgruppe_Benutzer> T_ZO_AP_Zylinder_AP_Schluesselgruppe_Benutzer { get; set; }
        public virtual T_ZO_Benutzer_Schedule T_ZO_Benutzer_Schedule { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_SYS_Settings_Benutzer> T_ZO_SYS_Settings_Benutzer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Ref_Mandant> T_AP_Ref_Mandant { get; set; }
    }
}

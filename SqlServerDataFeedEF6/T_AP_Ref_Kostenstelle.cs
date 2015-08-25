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
    
    public partial class T_AP_Ref_Kostenstelle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Ref_Kostenstelle()
        {
            this.T_AP_Informatik = new HashSet<T_AP_Informatik>();
            this.T_AP_Kommunikation = new HashSet<T_AP_Kommunikation>();
            this.T_AP_Kontakte = new HashSet<T_AP_Kontakte>();
            this.T_AP_Ref_Kostenstelle_Raiffeisen = new HashSet<T_AP_Ref_Kostenstelle_Raiffeisen>();
            this.T_UM_Planung = new HashSet<T_UM_Planung>();
            this.T_UPS_BudgetPositionen = new HashSet<T_UPS_BudgetPositionen>();
            this.T_ZO_AP_Arbeitsplatz_AP_Ref_Kostenstelle = new HashSet<T_ZO_AP_Arbeitsplatz_AP_Ref_Kostenstelle>();
            this.T_ZO_AP_Aussenobjekt_AP_Ref_Kostenstelle = new HashSet<T_ZO_AP_Aussenobjekt_AP_Ref_Kostenstelle>();
            this.T_ZO_AP_Kontakte_AP_Ref_Kostenstelle = new HashSet<T_ZO_AP_Kontakte_AP_Ref_Kostenstelle>();
            this.T_ZO_AP_Parkplatz_AP_Ref_Kostenstelle = new HashSet<T_ZO_AP_Parkplatz_AP_Ref_Kostenstelle>();
            this.T_ZO_AP_Raum_AP_Ref_Kostenstelle = new HashSet<T_ZO_AP_Raum_AP_Ref_Kostenstelle>();
            this.T_ZO_AP_Ref_Organisationseinheit_AP_Ref_Kostenstelle = new HashSet<T_ZO_AP_Ref_Organisationseinheit_AP_Ref_Kostenstelle>();
            this.T_ZO_AP_Zone_AP_Ref_Kostenstelle = new HashSet<T_ZO_AP_Zone_AP_Ref_Kostenstelle>();
        }
    
        public System.Guid KST_UID { get; set; }
        public int KST_MDT_ID { get; set; }
        public string KST_Code { get; set; }
        public string KST_Kurz_DE { get; set; }
        public string KST_Kurz_FR { get; set; }
        public string KST_Kurz_IT { get; set; }
        public string KST_Kurz_EN { get; set; }
        public string KST_Lang_DE { get; set; }
        public string KST_Lang_FR { get; set; }
        public string KST_Lang_IT { get; set; }
        public string KST_Lang_EN { get; set; }
        public int KST_Status { get; set; }
        public int KST_Sort { get; set; }
        public Nullable<int> KST_StylizerFore { get; set; }
        public Nullable<int> KST_StylizerBack { get; set; }
        public Nullable<int> KST_StylizerPattern { get; set; }
        public Nullable<int> KST_StylizerLine { get; set; }
        public bool KST_IsDefault { get; set; }
        public Nullable<System.DateTime> KST_DatumMut { get; set; }
        public string KST_DatumUser { get; set; }
        public Nullable<bool> KST_canHaveSL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Informatik> T_AP_Informatik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Kommunikation> T_AP_Kommunikation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Kontakte> T_AP_Kontakte { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Ref_Kostenstelle_Raiffeisen> T_AP_Ref_Kostenstelle_Raiffeisen { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_UM_Planung> T_UM_Planung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_UPS_BudgetPositionen> T_UPS_BudgetPositionen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Arbeitsplatz_AP_Ref_Kostenstelle> T_ZO_AP_Arbeitsplatz_AP_Ref_Kostenstelle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Aussenobjekt_AP_Ref_Kostenstelle> T_ZO_AP_Aussenobjekt_AP_Ref_Kostenstelle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Kontakte_AP_Ref_Kostenstelle> T_ZO_AP_Kontakte_AP_Ref_Kostenstelle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Parkplatz_AP_Ref_Kostenstelle> T_ZO_AP_Parkplatz_AP_Ref_Kostenstelle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Raum_AP_Ref_Kostenstelle> T_ZO_AP_Raum_AP_Ref_Kostenstelle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Ref_Organisationseinheit_AP_Ref_Kostenstelle> T_ZO_AP_Ref_Organisationseinheit_AP_Ref_Kostenstelle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Zone_AP_Ref_Kostenstelle> T_ZO_AP_Zone_AP_Ref_Kostenstelle { get; set; }
    }
}

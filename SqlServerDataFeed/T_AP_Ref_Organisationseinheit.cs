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
    
    public partial class T_AP_Ref_Organisationseinheit
    {
        public T_AP_Ref_Organisationseinheit()
        {
            this.T_AP_Kontakte = new HashSet<T_AP_Kontakte>();
            this.T_AP_Ref_Organisationseinheit_Raiffeisen = new HashSet<T_AP_Ref_Organisationseinheit_Raiffeisen>();
            this.T_ZO_AP_Arbeitsplatz_AP_Ref_Organisationseinheit = new HashSet<T_ZO_AP_Arbeitsplatz_AP_Ref_Organisationseinheit>();
            this.T_ZO_AP_Kontakte_AP_Ref_Organisationseinheit = new HashSet<T_ZO_AP_Kontakte_AP_Ref_Organisationseinheit>();
            this.T_ZO_AP_Raum_AP_Ref_Organisationseinheit = new HashSet<T_ZO_AP_Raum_AP_Ref_Organisationseinheit>();
            this.T_ZO_AP_Ref_Organisationseinheit_AP_Ref_Kostenstelle = new HashSet<T_ZO_AP_Ref_Organisationseinheit_AP_Ref_Kostenstelle>();
            this.T_ZO_AP_Zone_AP_Ref_Organisationseinheit = new HashSet<T_ZO_AP_Zone_AP_Ref_Organisationseinheit>();
        }
    
        public System.Guid KOE_UID { get; set; }
        public string KOE_Code { get; set; }
        public string KOE_Kurz_DE { get; set; }
        public string KOE_Kurz_FR { get; set; }
        public string KOE_Kurz_IT { get; set; }
        public string KOE_Kurz_EN { get; set; }
        public string KOE_Lang_DE { get; set; }
        public string KOE_Lang_FR { get; set; }
        public string KOE_Lang_IT { get; set; }
        public string KOE_Lang_EN { get; set; }
        public int KOE_Status { get; set; }
        public int KOE_Sort { get; set; }
        public Nullable<int> KOE_StylizerBack { get; set; }
        public Nullable<int> KOE_StylizerPattern { get; set; }
        public Nullable<int> KOE_StylizerLine { get; set; }
        public bool KOE_IsDefault { get; set; }
        public Nullable<System.DateTime> KOE_DatumMut { get; set; }
        public string KOE_DatumUser { get; set; }
        public Nullable<bool> KOE_IsFromOdis { get; set; }
        public Nullable<System.Guid> KOE_KST_UID { get; set; }
        public Nullable<System.Guid> KOE_KOE_UID { get; set; }
    
        public virtual ICollection<T_AP_Kontakte> T_AP_Kontakte { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual ICollection<T_AP_Ref_Organisationseinheit_Raiffeisen> T_AP_Ref_Organisationseinheit_Raiffeisen { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        public virtual ICollection<T_ZO_AP_Arbeitsplatz_AP_Ref_Organisationseinheit> T_ZO_AP_Arbeitsplatz_AP_Ref_Organisationseinheit { get; set; }
        public virtual ICollection<T_ZO_AP_Kontakte_AP_Ref_Organisationseinheit> T_ZO_AP_Kontakte_AP_Ref_Organisationseinheit { get; set; }
        public virtual ICollection<T_ZO_AP_Raum_AP_Ref_Organisationseinheit> T_ZO_AP_Raum_AP_Ref_Organisationseinheit { get; set; }
        public virtual ICollection<T_ZO_AP_Ref_Organisationseinheit_AP_Ref_Kostenstelle> T_ZO_AP_Ref_Organisationseinheit_AP_Ref_Kostenstelle { get; set; }
        public virtual ICollection<T_ZO_AP_Zone_AP_Ref_Organisationseinheit> T_ZO_AP_Zone_AP_Ref_Organisationseinheit { get; set; }
    }
}

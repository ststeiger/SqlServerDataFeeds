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
    
    public partial class T_AP_Ref_Mietobjekt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Ref_Mietobjekt()
        {
            this.T_ZO_AP_Aussenobjekt_AP_Ref_Mietobjekt = new HashSet<T_ZO_AP_Aussenobjekt_AP_Ref_Mietobjekt>();
            this.T_ZO_AP_Parkplatz_AP_Ref_Mietobjekt = new HashSet<T_ZO_AP_Parkplatz_AP_Ref_Mietobjekt>();
            this.T_ZO_AP_Raum_AP_Ref_Mietobjekt = new HashSet<T_ZO_AP_Raum_AP_Ref_Mietobjekt>();
            this.T_ZO_AP_Zone_AP_Ref_Mietobjekt = new HashSet<T_ZO_AP_Zone_AP_Ref_Mietobjekt>();
        }
    
        public System.Guid MIO_UID { get; set; }
        public int MIO_MDT_ID { get; set; }
        public string MIO_Code { get; set; }
        public string MIO_Kurz_DE { get; set; }
        public string MIO_Kurz_FR { get; set; }
        public string MIO_Kurz_IT { get; set; }
        public string MIO_Kurz_EN { get; set; }
        public string MIO_Lang_DE { get; set; }
        public string MIO_Lang_FR { get; set; }
        public string MIO_Lang_IT { get; set; }
        public string MIO_Lang_EN { get; set; }
        public int MIO_Status { get; set; }
        public int MIO_Sort { get; set; }
        public Nullable<int> MIO_StylizerFore { get; set; }
        public Nullable<int> MIO_StylizerBack { get; set; }
        public Nullable<int> MIO_StylizerPattern { get; set; }
        public Nullable<int> MIO_StylizerLine { get; set; }
        public bool MIO_IsDefault { get; set; }
        public string MIO_SO_Nr { get; set; }
        public string MIO_HS_Nr { get; set; }
        public Nullable<System.DateTime> MIO_DatumVon { get; set; }
        public Nullable<System.DateTime> MIO_DatumBis { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Aussenobjekt_AP_Ref_Mietobjekt> T_ZO_AP_Aussenobjekt_AP_Ref_Mietobjekt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Parkplatz_AP_Ref_Mietobjekt> T_ZO_AP_Parkplatz_AP_Ref_Mietobjekt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Raum_AP_Ref_Mietobjekt> T_ZO_AP_Raum_AP_Ref_Mietobjekt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Zone_AP_Ref_Mietobjekt> T_ZO_AP_Zone_AP_Ref_Mietobjekt { get; set; }
    }
}

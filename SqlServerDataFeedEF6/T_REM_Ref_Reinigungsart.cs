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
    
    public partial class T_REM_Ref_Reinigungsart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_REM_Ref_Reinigungsart()
        {
            this.T_REM_Ref_Arbeitsgang = new HashSet<T_REM_Ref_Arbeitsgang>();
            this.T_REM_Ref_Vorlagen = new HashSet<T_REM_Ref_Vorlagen>();
            this.T_ZO_REM_AP_Raum_Ref_Reinigungsart_Kalk = new HashSet<T_ZO_REM_AP_Raum_Ref_Reinigungsart_Kalk>();
            this.T_ZO_REM_AP_Raum_Ref_Reinigungsart = new HashSet<T_ZO_REM_AP_Raum_Ref_Reinigungsart>();
        }
    
        public System.Guid REMRA_UID { get; set; }
        public Nullable<int> REMRA_Code { get; set; }
        public string REMRA_Kurz_de { get; set; }
        public string REMRA_Kurz_fr { get; set; }
        public string REMRA_Kurz_it { get; set; }
        public string REMRA_Kurz_en { get; set; }
        public string REMRA_Lang_de { get; set; }
        public string REMRA_Lang_fr { get; set; }
        public string REMRA_Lang_it { get; set; }
        public string REMRA_Lang_en { get; set; }
        public int REMRA_Status { get; set; }
        public int REMRA_Sort { get; set; }
        public bool REMRA_IsDefault { get; set; }
        public Nullable<int> REMRA_StylizerBack { get; set; }
        public Nullable<int> REMRA_StylizerFore { get; set; }
        public Nullable<int> REMRA_StylizerPattern { get; set; }
        public Nullable<int> REMRA_StylizerLine { get; set; }
        public int REMRA_MDT_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_REM_Ref_Arbeitsgang> T_REM_Ref_Arbeitsgang { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_REM_Ref_Vorlagen> T_REM_Ref_Vorlagen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_REM_AP_Raum_Ref_Reinigungsart_Kalk> T_ZO_REM_AP_Raum_Ref_Reinigungsart_Kalk { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_REM_AP_Raum_Ref_Reinigungsart> T_ZO_REM_AP_Raum_Ref_Reinigungsart { get; set; }
    }
}

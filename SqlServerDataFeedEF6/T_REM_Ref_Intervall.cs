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
    
    public partial class T_REM_Ref_Intervall
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_REM_Ref_Intervall()
        {
            this.T_REM_Ref_Vorlagen = new HashSet<T_REM_Ref_Vorlagen>();
            this.T_ZO_REM_AP_Raum_Reinigung_Kalk = new HashSet<T_ZO_REM_AP_Raum_Reinigung_Kalk>();
            this.T_ZO_REM_AP_Raum_Reinigung = new HashSet<T_ZO_REM_AP_Raum_Reinigung>();
        }
    
        public System.Guid REMIN_UID { get; set; }
        public Nullable<int> REMIN_Code { get; set; }
        public string REMIN_Kurz_de { get; set; }
        public string REMIN_Kurz_fr { get; set; }
        public string REMIN_Kurz_it { get; set; }
        public string REMIN_Kurz_en { get; set; }
        public string REMIN_Lang_de { get; set; }
        public string REMIN_Lang_fr { get; set; }
        public string REMIN_Lang_it { get; set; }
        public string REMIN_Lang_en { get; set; }
        public int REMIN_Status { get; set; }
        public int REMIN_Sort { get; set; }
        public bool REMIN_IsDefault { get; set; }
        public Nullable<int> REMIN_StylizerBack { get; set; }
        public Nullable<int> REMIN_StylizerFore { get; set; }
        public Nullable<int> REMIN_StylizerPattern { get; set; }
        public Nullable<int> REMIN_StylizerLine { get; set; }
    
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_REM_Ref_Vorlagen> T_REM_Ref_Vorlagen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_REM_AP_Raum_Reinigung_Kalk> T_ZO_REM_AP_Raum_Reinigung_Kalk { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_REM_AP_Raum_Reinigung> T_ZO_REM_AP_Raum_Reinigung { get; set; }
    }
}

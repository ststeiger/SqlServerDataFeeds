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
    
    public partial class T_AP_Ref_SchluesselKategorie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Ref_SchluesselKategorie()
        {
            this.T_AP_Schluesselgruppe = new HashSet<T_AP_Schluesselgruppe>();
        }
    
        public System.Guid SKAT_UID { get; set; }
        public int SKAT_MDT_ID { get; set; }
        public Nullable<int> SKAT_Code { get; set; }
        public string SKAT_Kurz_DE { get; set; }
        public string SKAT_Kurz_FR { get; set; }
        public string SKAT_Kurz_IT { get; set; }
        public string SKAT_Kurz_EN { get; set; }
        public string SKAT_Lang_DE { get; set; }
        public string SKAT_Lang_FR { get; set; }
        public string SKAT_Lang_IT { get; set; }
        public string SKAT_Lang_EN { get; set; }
        public int SKAT_Status { get; set; }
        public int SKAT_Sort { get; set; }
        public Nullable<int> SKAT_StylizerFore { get; set; }
        public Nullable<int> SKAT_StylizerBack { get; set; }
        public Nullable<int> SKAT_StylizerPattern { get; set; }
        public Nullable<int> SKAT_StylizerLine { get; set; }
        public bool SKAT_IsDefault { get; set; }
        public Nullable<System.DateTime> SKAT_DatumMut { get; set; }
        public string SKAT_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Schluesselgruppe> T_AP_Schluesselgruppe { get; set; }
    }
}

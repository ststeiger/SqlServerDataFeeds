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
    
    public partial class T_AP_Ref_FotoKategorie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Ref_FotoKategorie()
        {
            this.T_AP_Fotos = new HashSet<T_AP_Fotos>();
        }
    
        public System.Guid FKAT_UID { get; set; }
        public int FKAT_MDT_ID { get; set; }
        public Nullable<int> FKAT_Code { get; set; }
        public string FKAT_Kurz_DE { get; set; }
        public string FKAT_Kurz_FR { get; set; }
        public string FKAT_Kurz_IT { get; set; }
        public string FKAT_Kurz_EN { get; set; }
        public string FKAT_Lang_DE { get; set; }
        public string FKAT_Lang_FR { get; set; }
        public string FKAT_Lang_IT { get; set; }
        public string FKAT_Lang_EN { get; set; }
        public int FKAT_Status { get; set; }
        public int FKAT_Sort { get; set; }
        public Nullable<int> FKAT_StylizerFore { get; set; }
        public Nullable<int> FKAT_StylizerBack { get; set; }
        public Nullable<int> FKAT_StylizerPattern { get; set; }
        public Nullable<int> FKAT_StylizerLine { get; set; }
        public bool FKAT_IsDefault { get; set; }
        public Nullable<System.DateTime> FKAT_DatumMut { get; set; }
        public string FKAT_DatumUser { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Fotos> T_AP_Fotos { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

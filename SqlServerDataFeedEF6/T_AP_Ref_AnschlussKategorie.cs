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
    
    public partial class T_AP_Ref_AnschlussKategorie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Ref_AnschlussKategorie()
        {
            this.T_AP_Anschluss = new HashSet<T_AP_Anschluss>();
            this.T_AP_Ref_AnschlussTyp = new HashSet<T_AP_Ref_AnschlussTyp>();
        }
    
        public System.Guid ANKAT_UID { get; set; }
        public int ANKAT_MDT_ID { get; set; }
        public Nullable<int> ANKAT_Code { get; set; }
        public string ANKAT_Kurz_DE { get; set; }
        public string ANKAT_Kurz_FR { get; set; }
        public string ANKAT_Kurz_IT { get; set; }
        public string ANKAT_Kurz_EN { get; set; }
        public string ANKAT_Lang_DE { get; set; }
        public string ANKAT_Lang_FR { get; set; }
        public string ANKAT_Lang_IT { get; set; }
        public string ANKAT_Lang_EN { get; set; }
        public int ANKAT_Status { get; set; }
        public int ANKAT_Sort { get; set; }
        public Nullable<int> ANKAT_StylizerFore { get; set; }
        public Nullable<int> ANKAT_StylizerBack { get; set; }
        public Nullable<int> ANKAT_StylizerPattern { get; set; }
        public Nullable<int> ANKAT_StylizerLine { get; set; }
        public bool ANKAT_IsDefault { get; set; }
        public Nullable<System.DateTime> ANKAT_DatumMut { get; set; }
        public string ANKAT_DatumUser { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Anschluss> T_AP_Anschluss { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Ref_AnschlussTyp> T_AP_Ref_AnschlussTyp { get; set; }
    }
}

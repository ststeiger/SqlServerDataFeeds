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
    
    public partial class T_AP_Ref_AnschlussTyp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Ref_AnschlussTyp()
        {
            this.T_AP_Anschluss = new HashSet<T_AP_Anschluss>();
        }
    
        public System.Guid ANT_UID { get; set; }
        public int ANT_MDT_ID { get; set; }
        public Nullable<System.Guid> ANT_ANKAT_UID { get; set; }
        public Nullable<int> ANT_Code { get; set; }
        public string ANT_Kurz_DE { get; set; }
        public string ANT_Kurz_FR { get; set; }
        public string ANT_Kurz_IT { get; set; }
        public string ANT_Kurz_EN { get; set; }
        public string ANT_Lang_DE { get; set; }
        public string ANT_Lang_FR { get; set; }
        public string ANT_Lang_IT { get; set; }
        public string ANT_Lang_EN { get; set; }
        public int ANT_Status { get; set; }
        public int ANT_Sort { get; set; }
        public Nullable<int> ANT_StylizerFore { get; set; }
        public Nullable<int> ANT_StylizerBack { get; set; }
        public Nullable<int> ANT_StylizerPattern { get; set; }
        public Nullable<int> ANT_StylizerLine { get; set; }
        public bool ANT_IsDefault { get; set; }
        public Nullable<System.DateTime> ANT_DatumMut { get; set; }
        public string ANT_DatumUser { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Anschluss> T_AP_Anschluss { get; set; }
        public virtual T_AP_Ref_AnschlussKategorie T_AP_Ref_AnschlussKategorie { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

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
    
    public partial class T_AP_Ref_GebaeudeEinstufung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Ref_GebaeudeEinstufung()
        {
            this.T_AP_Gebaeude = new HashSet<T_AP_Gebaeude>();
            this.T_AP_Trakt = new HashSet<T_AP_Trakt>();
        }
    
        public System.Guid GES_UID { get; set; }
        public int GES_MDT_ID { get; set; }
        public Nullable<int> GES_Code { get; set; }
        public string GES_Kurz_DE { get; set; }
        public string GES_Kurz_FR { get; set; }
        public string GES_Kurz_IT { get; set; }
        public string GES_Kurz_EN { get; set; }
        public string GES_Lang_DE { get; set; }
        public string GES_Lang_FR { get; set; }
        public string GES_Lang_IT { get; set; }
        public string GES_Lang_EN { get; set; }
        public int GES_Status { get; set; }
        public int GES_Sort { get; set; }
        public Nullable<int> GES_StylizerFore { get; set; }
        public Nullable<int> GES_StylizerBack { get; set; }
        public Nullable<int> GES_StylizerPattern { get; set; }
        public Nullable<int> GES_StylizerLine { get; set; }
        public bool GES_IsDefault { get; set; }
        public Nullable<System.DateTime> GES_DatumMut { get; set; }
        public string GES_DatumUser { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Gebaeude> T_AP_Gebaeude { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Trakt> T_AP_Trakt { get; set; }
    }
}

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
    
    public partial class T_AP_Ref_Land
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Ref_Land()
        {
            this.T_AP_Ref_Region = new HashSet<T_AP_Ref_Region>();
        }
    
        public System.Guid LD_UID { get; set; }
        public int LD_MDT_ID { get; set; }
        public Nullable<System.Guid> LD_LT_UID { get; set; }
        public string LD_Code { get; set; }
        public string LD_Kurz_DE { get; set; }
        public string LD_Kurz_FR { get; set; }
        public string LD_Kurz_IT { get; set; }
        public string LD_Kurz_EN { get; set; }
        public string LD_Lang_DE { get; set; }
        public string LD_Lang_FR { get; set; }
        public string LD_Lang_IT { get; set; }
        public string LD_Lang_EN { get; set; }
        public int LD_Status { get; set; }
        public int LD_Sort { get; set; }
        public Nullable<int> LD_StylizerFore { get; set; }
        public Nullable<int> LD_StylizerBack { get; set; }
        public Nullable<int> LD_StylizerPattern { get; set; }
        public Nullable<int> LD_StylizerLine { get; set; }
        public bool LD_IsDefault { get; set; }
        public Nullable<System.DateTime> LD_DatumMut { get; set; }
        public string LD_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Landesteile T_AP_Ref_Landesteile { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Ref_Region> T_AP_Ref_Region { get; set; }
    }
}
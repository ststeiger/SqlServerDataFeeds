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
    
    public partial class T_AP_Ref_Landesteile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Ref_Landesteile()
        {
            this.T_AP_Ref_Land = new HashSet<T_AP_Ref_Land>();
        }
    
        public System.Guid LT_UID { get; set; }
        public int LT_MDT_ID { get; set; }
        public Nullable<int> LT_Code { get; set; }
        public string LT_Kurz_DE { get; set; }
        public string LT_Kurz_FR { get; set; }
        public string LT_Kurz_IT { get; set; }
        public string LT_Kurz_EN { get; set; }
        public string LT_Lang_DE { get; set; }
        public string LT_Lang_FR { get; set; }
        public string LT_Lang_IT { get; set; }
        public string LT_Lang_EN { get; set; }
        public int LT_Status { get; set; }
        public int LT_Sort { get; set; }
        public Nullable<int> LT_StylizerBack { get; set; }
        public Nullable<int> LT_StylizerFore { get; set; }
        public Nullable<int> LT_StylizerPattern { get; set; }
        public Nullable<int> LT_StylizerLine { get; set; }
        public bool LT_IsDefault { get; set; }
        public Nullable<System.DateTime> LT_DatumMut { get; set; }
        public string LT_DatumUser { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Ref_Land> T_AP_Ref_Land { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}
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
    
    public partial class T_AP_Ref_AussenobjektBodenbelag
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Ref_AussenobjektBodenbelag()
        {
            this.T_AP_Aussenobjekt = new HashSet<T_AP_Aussenobjekt>();
        }
    
        public System.Guid BB_UID { get; set; }
        public int BB_MDT_ID { get; set; }
        public Nullable<int> BB_Code { get; set; }
        public string BB_Kurz_DE { get; set; }
        public string BB_Kurz_FR { get; set; }
        public string BB_Kurz_IT { get; set; }
        public string BB_Kurz_EN { get; set; }
        public string BB_Lang_DE { get; set; }
        public string BB_Lang_FR { get; set; }
        public string BB_Lang_IT { get; set; }
        public string BB_Lang_EN { get; set; }
        public int BB_Status { get; set; }
        public int BB_Sort { get; set; }
        public Nullable<int> BB_StylizerFore { get; set; }
        public Nullable<int> BB_StylizerBack { get; set; }
        public Nullable<int> BB_StylizerPattern { get; set; }
        public Nullable<int> BB_StylizerLine { get; set; }
        public bool BB_IsDefault { get; set; }
        public Nullable<System.DateTime> BB_DatumMut { get; set; }
        public string BB_DatumUser { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Aussenobjekt> T_AP_Aussenobjekt { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

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
    
    public partial class T_AP_Ref_ZylinderTyp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Ref_ZylinderTyp()
        {
            this.T_AP_Zylinder = new HashSet<T_AP_Zylinder>();
        }
    
        public System.Guid ZYLT_UID { get; set; }
        public int ZYLT_MDT_ID { get; set; }
        public Nullable<int> ZYLT_Code { get; set; }
        public string ZYLT_Kurz_DE { get; set; }
        public string ZYLT_Kurz_FR { get; set; }
        public string ZYLT_Kurz_IT { get; set; }
        public string ZYLT_Kurz_EN { get; set; }
        public string ZYLT_Lang_DE { get; set; }
        public string ZYLT_Lang_FR { get; set; }
        public string ZYLT_Lang_IT { get; set; }
        public string ZYLT_Lang_EN { get; set; }
        public int ZYLT_Status { get; set; }
        public int ZYLT_Sort { get; set; }
        public Nullable<int> ZYLT_StylizerFore { get; set; }
        public Nullable<int> ZYLT_StylizerBack { get; set; }
        public Nullable<int> ZYLT_StylizerPattern { get; set; }
        public Nullable<int> ZYLT_StylizerLine { get; set; }
        public bool ZYLT_IsDefault { get; set; }
        public Nullable<System.DateTime> ZYLT_DatumMut { get; set; }
        public string ZYLT_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Zylinder> T_AP_Zylinder { get; set; }
    }
}
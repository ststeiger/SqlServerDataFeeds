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
    
    public partial class T_AP_Ref_KunstRahmenArt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Ref_KunstRahmenArt()
        {
            this.T_AP_Kunst = new HashSet<T_AP_Kunst>();
        }
    
        public System.Guid KR_UID { get; set; }
        public int KR_MDT_ID { get; set; }
        public Nullable<int> KR_Code { get; set; }
        public string KR_Kurz_DE { get; set; }
        public string KR_Kurz_FR { get; set; }
        public string KR_Kurz_IT { get; set; }
        public string KR_Kurz_EN { get; set; }
        public string KR_Lang_DE { get; set; }
        public string KR_Lang_FR { get; set; }
        public string KR_Lang_IT { get; set; }
        public string KR_Lang_EN { get; set; }
        public int KR_Status { get; set; }
        public int KR_Sort { get; set; }
        public Nullable<int> KR_StylizerFore { get; set; }
        public Nullable<int> KR_StylizerBack { get; set; }
        public Nullable<int> KR_StylizerPattern { get; set; }
        public Nullable<int> KR_StylizerLine { get; set; }
        public bool KR_IsDefault { get; set; }
        public bool KR_IsFreeText { get; set; }
        public Nullable<System.DateTime> KR_DatumMut { get; set; }
        public string KR_DatumUser { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Kunst> T_AP_Kunst { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

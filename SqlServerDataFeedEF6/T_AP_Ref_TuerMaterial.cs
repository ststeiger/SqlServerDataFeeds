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
    
    public partial class T_AP_Ref_TuerMaterial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Ref_TuerMaterial()
        {
            this.T_AP_Tuer = new HashSet<T_AP_Tuer>();
        }
    
        public System.Guid TM_UID { get; set; }
        public int TM_MDT_ID { get; set; }
        public Nullable<int> TM_Code { get; set; }
        public string TM_Kurz_DE { get; set; }
        public string TM_Kurz_FR { get; set; }
        public string TM_Kurz_IT { get; set; }
        public string TM_Kurz_EN { get; set; }
        public string TM_Lang_DE { get; set; }
        public string TM_Lang_FR { get; set; }
        public string TM_Lang_IT { get; set; }
        public string TM_Lang_EN { get; set; }
        public int TM_Status { get; set; }
        public int TM_Sort { get; set; }
        public Nullable<int> TM_StylizerFore { get; set; }
        public Nullable<int> TM_StylizerBack { get; set; }
        public Nullable<int> TM_StylizerPattern { get; set; }
        public Nullable<int> TM_StylizerLine { get; set; }
        public bool TM_IsDefault { get; set; }
        public Nullable<System.DateTime> TM_DatumMut { get; set; }
        public string TM_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Tuer> T_AP_Tuer { get; set; }
    }
}

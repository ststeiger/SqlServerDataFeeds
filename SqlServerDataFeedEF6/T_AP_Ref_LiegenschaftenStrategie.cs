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
    
    public partial class T_AP_Ref_LiegenschaftenStrategie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Ref_LiegenschaftenStrategie()
        {
            this.T_AP_Gebaeude = new HashSet<T_AP_Gebaeude>();
        }
    
        public System.Guid LS_UID { get; set; }
        public int LS_MDT_ID { get; set; }
        public Nullable<int> LS_Code { get; set; }
        public string LS_Kurz_DE { get; set; }
        public string LS_Kurz_FR { get; set; }
        public string LS_Kurz_IT { get; set; }
        public string LS_Kurz_EN { get; set; }
        public string LS_Lang_DE { get; set; }
        public string LS_Lang_FR { get; set; }
        public string LS_Lang_IT { get; set; }
        public string LS_Lang_EN { get; set; }
        public int LS_Status { get; set; }
        public int LS_Sort { get; set; }
        public Nullable<int> LS_StylizerFore { get; set; }
        public Nullable<int> LS_StylizerBack { get; set; }
        public Nullable<int> LS_StylizerPattern { get; set; }
        public Nullable<int> LS_StylizerLine { get; set; }
        public bool LS_IsDefault { get; set; }
        public Nullable<System.DateTime> LS_DatumMut { get; set; }
        public string LS_DatumUser { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Gebaeude> T_AP_Gebaeude { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

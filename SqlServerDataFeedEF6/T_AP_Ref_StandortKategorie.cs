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
    
    public partial class T_AP_Ref_StandortKategorie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Ref_StandortKategorie()
        {
            this.T_AP_Gebaeude = new HashSet<T_AP_Gebaeude>();
        }
    
        public System.Guid SK_UID { get; set; }
        public int SK_MDT_ID { get; set; }
        public Nullable<int> SK_Code { get; set; }
        public string SK_Kurz_DE { get; set; }
        public string SK_Kurz_FR { get; set; }
        public string SK_Kurz_IT { get; set; }
        public string SK_Kurz_EN { get; set; }
        public string SK_Lang_DE { get; set; }
        public string SK_Lang_FR { get; set; }
        public string SK_Lang_IT { get; set; }
        public string SK_Lang_EN { get; set; }
        public int SK_Status { get; set; }
        public int SK_Sort { get; set; }
        public Nullable<int> SK_StylizerFore { get; set; }
        public Nullable<int> SK_StylizerBack { get; set; }
        public Nullable<int> SK_StylizerPattern { get; set; }
        public Nullable<int> SK_StylizerLine { get; set; }
        public bool SK_IsDefault { get; set; }
        public Nullable<System.DateTime> SK_DatumMut { get; set; }
        public string SK_DatumUser { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Gebaeude> T_AP_Gebaeude { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

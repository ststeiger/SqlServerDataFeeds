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
    
    public partial class T_AP_Ref_Energiebezugsart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Ref_Energiebezugsart()
        {
            this.T_ZO_AP_Raum_AP_Ref_Energiebezugsart = new HashSet<T_ZO_AP_Raum_AP_Ref_Energiebezugsart>();
        }
    
        public System.Guid EBA_UID { get; set; }
        public int EBA_MDT_ID { get; set; }
        public Nullable<int> EBA_Code { get; set; }
        public string EBA_Kurz_DE { get; set; }
        public string EBA_Kurz_FR { get; set; }
        public string EBA_Kurz_IT { get; set; }
        public string EBA_Kurz_EN { get; set; }
        public string EBA_Lang_DE { get; set; }
        public string EBA_Lang_FR { get; set; }
        public string EBA_Lang_IT { get; set; }
        public string EBA_Lang_EN { get; set; }
        public int EBA_Status { get; set; }
        public int EBA_Sort { get; set; }
        public Nullable<int> EBA_StylizerFore { get; set; }
        public Nullable<int> EBA_StylizerBack { get; set; }
        public Nullable<int> EBA_StylizerPattern { get; set; }
        public Nullable<int> EBA_StylizerLine { get; set; }
        public bool EBA_IsDefault { get; set; }
        public Nullable<System.DateTime> EBA_DatumMut { get; set; }
        public string EBA_DatumUser { get; set; }
    
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Raum_AP_Ref_Energiebezugsart> T_ZO_AP_Raum_AP_Ref_Energiebezugsart { get; set; }
    }
}

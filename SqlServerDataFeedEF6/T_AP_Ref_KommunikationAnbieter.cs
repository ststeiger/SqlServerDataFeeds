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
    
    public partial class T_AP_Ref_KommunikationAnbieter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Ref_KommunikationAnbieter()
        {
            this.T_AP_Kommunikation = new HashSet<T_AP_Kommunikation>();
        }
    
        public System.Guid KMA_UID { get; set; }
        public int KMA_MDT_ID { get; set; }
        public Nullable<int> KMA_Code { get; set; }
        public string KMA_Kurz_DE { get; set; }
        public string KMA_Kurz_FR { get; set; }
        public string KMA_Kurz_IT { get; set; }
        public string KMA_Kurz_EN { get; set; }
        public string KMA_Lang_DE { get; set; }
        public string KMA_Lang_FR { get; set; }
        public string KMA_Lang_IT { get; set; }
        public string KMA_Lang_EN { get; set; }
        public int KMA_Status { get; set; }
        public int KMA_Sort { get; set; }
        public Nullable<int> KMA_StylizerFore { get; set; }
        public Nullable<int> KMA_StylizerBack { get; set; }
        public Nullable<int> KMA_StylizerPattern { get; set; }
        public Nullable<int> KMA_StylizerLine { get; set; }
        public bool KMA_IsDefault { get; set; }
        public Nullable<System.DateTime> KMA_DatumMut { get; set; }
        public string KMA_DatumUser { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Kommunikation> T_AP_Kommunikation { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

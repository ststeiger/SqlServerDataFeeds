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
    
    public partial class T_AP_Ref_InformatikBetriebssystem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Ref_InformatikBetriebssystem()
        {
            this.T_AP_Informatik = new HashSet<T_AP_Informatik>();
        }
    
        public System.Guid IBS_UID { get; set; }
        public int IBS_MDT_ID { get; set; }
        public Nullable<int> IBS_Code { get; set; }
        public string IBS_Kurz_DE { get; set; }
        public string IBS_Kurz_FR { get; set; }
        public string IBS_Kurz_IT { get; set; }
        public string IBS_Kurz_EN { get; set; }
        public string IBS_Lang_DE { get; set; }
        public string IBS_Lang_FR { get; set; }
        public string IBS_Lang_IT { get; set; }
        public string IBS_Lang_EN { get; set; }
        public int IBS_Status { get; set; }
        public int IBS_Sort { get; set; }
        public Nullable<int> IBS_StylizerFore { get; set; }
        public Nullable<int> IBS_StylizerBack { get; set; }
        public Nullable<int> IBS_StylizerPattern { get; set; }
        public Nullable<int> IBS_StylizerLine { get; set; }
        public bool IBS_IsDefault { get; set; }
        public Nullable<System.DateTime> IBS_DatumMut { get; set; }
        public string IBS_DatumUser { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Informatik> T_AP_Informatik { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}
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
    
    public partial class T_AP_Ref_DokumentGrund
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Ref_DokumentGrund()
        {
            this.T_AP_Dokumente_Log = new HashSet<T_AP_Dokumente_Log>();
        }
    
        public System.Guid DG_UID { get; set; }
        public int DG_MDT_ID { get; set; }
        public Nullable<int> DG_Code { get; set; }
        public string DG_Kurz_DE { get; set; }
        public string DG_Kurz_FR { get; set; }
        public string DG_Kurz_IT { get; set; }
        public string DG_Kurz_EN { get; set; }
        public string DG_Lang_DE { get; set; }
        public string DG_Lang_FR { get; set; }
        public string DG_Lang_IT { get; set; }
        public string DG_Lang_EN { get; set; }
        public int DG_Status { get; set; }
        public int DG_Sort { get; set; }
        public Nullable<int> DG_StylizerFore { get; set; }
        public Nullable<int> DG_StylizerBack { get; set; }
        public Nullable<int> DG_StylizerPattern { get; set; }
        public Nullable<int> DG_StylizerLine { get; set; }
        public bool DG_IsDefault { get; set; }
        public Nullable<System.DateTime> DG_DatumMut { get; set; }
        public string DG_DatumUser { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Dokumente_Log> T_AP_Dokumente_Log { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

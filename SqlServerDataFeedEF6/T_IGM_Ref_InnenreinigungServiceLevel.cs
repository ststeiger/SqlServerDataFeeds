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
    
    public partial class T_IGM_Ref_InnenreinigungServiceLevel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_IGM_Ref_InnenreinigungServiceLevel()
        {
            this.T_AP_Raum = new HashSet<T_AP_Raum>();
        }
    
        public System.Guid ISL_UID { get; set; }
        public int ISL_MDT_ID { get; set; }
        public Nullable<int> ISL_Code { get; set; }
        public string ISL_Kurz_DE { get; set; }
        public string ISL_Kurz_FR { get; set; }
        public string ISL_Kurz_IT { get; set; }
        public string ISL_Kurz_EN { get; set; }
        public string ISL_Lang_DE { get; set; }
        public string ISL_Lang_FR { get; set; }
        public string ISL_Lang_IT { get; set; }
        public string ISL_Lang_EN { get; set; }
        public int ISL_Status { get; set; }
        public int ISL_Sort { get; set; }
        public Nullable<int> ISL_StylizerFore { get; set; }
        public Nullable<int> ISL_StylizerBack { get; set; }
        public Nullable<int> ISL_StylizerPattern { get; set; }
        public Nullable<int> ISL_StylizerLine { get; set; }
        public bool ISL_IsDefault { get; set; }
        public Nullable<System.DateTime> ISL_DatumMut { get; set; }
        public string ISL_DatumUser { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Raum> T_AP_Raum { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

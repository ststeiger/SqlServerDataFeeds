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
    
    public partial class T_VM_Ref_Vertragszustaendigkeit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_VM_Ref_Vertragszustaendigkeit()
        {
            this.T_VM_Vertraege = new HashSet<T_VM_Vertraege>();
        }
    
        public System.Guid VZ_UID { get; set; }
        public int VZ_MDT_ID { get; set; }
        public Nullable<int> VZ_Code { get; set; }
        public string VZ_Kurz_DE { get; set; }
        public string VZ_Kurz_FR { get; set; }
        public string VZ_Kurz_IT { get; set; }
        public string VZ_Kurz_EN { get; set; }
        public string VZ_Lang_DE { get; set; }
        public string VZ_Lang_FR { get; set; }
        public string VZ_Lang_IT { get; set; }
        public string VZ_Lang_EN { get; set; }
        public int VZ_Status { get; set; }
        public int VZ_Sort { get; set; }
        public Nullable<int> VZ_StylizerFore { get; set; }
        public Nullable<int> VZ_StylizerBack { get; set; }
        public Nullable<int> VZ_StylizerPattern { get; set; }
        public Nullable<int> VZ_StylizerLine { get; set; }
        public bool VZ_IsDefault { get; set; }
        public Nullable<System.DateTime> VZ_DatumMut { get; set; }
        public string VZ_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_VM_Vertraege> T_VM_Vertraege { get; set; }
    }
}

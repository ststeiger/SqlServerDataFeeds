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
    
    public partial class T_TM_Ref_ZyklusPeriode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_TM_Ref_ZyklusPeriode()
        {
            this.T_TM_Tasks_Planung = new HashSet<T_TM_Tasks_Planung>();
            this.T_TM_Tasks_Planung1 = new HashSet<T_TM_Tasks_Planung>();
            this.T_VM_Vertraege = new HashSet<T_VM_Vertraege>();
            this.T_VM_Vertraege1 = new HashSet<T_VM_Vertraege>();
        }
    
        public System.Guid ZYP_UID { get; set; }
        public int ZYP_MDT_ID { get; set; }
        public Nullable<int> ZYP_Code { get; set; }
        public string ZYP_Kurz_DE { get; set; }
        public string ZYP_Kurz_FR { get; set; }
        public string ZYP_Kurz_IT { get; set; }
        public string ZYP_Kurz_EN { get; set; }
        public string ZYP_Lang_DE { get; set; }
        public string ZYP_Lang_FR { get; set; }
        public string ZYP_Lang_IT { get; set; }
        public string ZYP_Lang_EN { get; set; }
        public int ZYP_Status { get; set; }
        public int ZYP_Sort { get; set; }
        public Nullable<int> ZYP_StylizerFore { get; set; }
        public Nullable<int> ZYP_StylizerBack { get; set; }
        public Nullable<int> ZYP_StylizerPattern { get; set; }
        public Nullable<int> ZYP_StylizerLine { get; set; }
        public bool ZYP_IsDefault { get; set; }
        public Nullable<System.DateTime> ZYP_DatumMut { get; set; }
        public string ZYP_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TM_Tasks_Planung> T_TM_Tasks_Planung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TM_Tasks_Planung> T_TM_Tasks_Planung1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_VM_Vertraege> T_VM_Vertraege { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_VM_Vertraege> T_VM_Vertraege1 { get; set; }
    }
}
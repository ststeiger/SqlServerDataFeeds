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
    
    public partial class T_REM_Ref_BB_Beschaffenheit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_REM_Ref_BB_Beschaffenheit()
        {
            this.T_REM_Ref_Bodenbelag = new HashSet<T_REM_Ref_Bodenbelag>();
        }
    
        public System.Guid REMBS_UID { get; set; }
        public Nullable<int> REMBS_Code { get; set; }
        public string REMBS_Kurz_de { get; set; }
        public string REMBS_Kurz_fr { get; set; }
        public string REMBS_Kurz_it { get; set; }
        public string REMBS_Kurz_en { get; set; }
        public string REMBS_Lang_de { get; set; }
        public string REMBS_Lang_fr { get; set; }
        public string REMBS_Lang_it { get; set; }
        public string REMBS_Lang_en { get; set; }
        public int REMBS_Status { get; set; }
        public int REMBS_Sort { get; set; }
        public bool REMBS_IsDefault { get; set; }
        public Nullable<int> REMBS_StylizerBack { get; set; }
        public Nullable<int> REMBS_StylizerFore { get; set; }
        public Nullable<int> REMBS_StylizerPattern { get; set; }
        public Nullable<int> REMBS_StylizerLine { get; set; }
    
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_REM_Ref_Bodenbelag> T_REM_Ref_Bodenbelag { get; set; }
    }
}

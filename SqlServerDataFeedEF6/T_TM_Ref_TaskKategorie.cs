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
    
    public partial class T_TM_Ref_TaskKategorie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_TM_Ref_TaskKategorie()
        {
            this.T_TM_Ref_Checkliste = new HashSet<T_TM_Ref_Checkliste>();
            this.T_TM_Ref_TaskArt = new HashSet<T_TM_Ref_TaskArt>();
        }
    
        public System.Guid TKAT_UID { get; set; }
        public int TKAT_MDT_ID { get; set; }
        public Nullable<int> TKAT_Code { get; set; }
        public string TKAT_Kurz_DE { get; set; }
        public string TKAT_Kurz_FR { get; set; }
        public string TKAT_Kurz_IT { get; set; }
        public string TKAT_Kurz_EN { get; set; }
        public string TKAT_Lang_DE { get; set; }
        public string TKAT_Lang_FR { get; set; }
        public string TKAT_Lang_IT { get; set; }
        public string TKAT_Lang_EN { get; set; }
        public int TKAT_Status { get; set; }
        public int TKAT_Sort { get; set; }
        public Nullable<int> TKAT_StylizerFore { get; set; }
        public Nullable<int> TKAT_StylizerBack { get; set; }
        public Nullable<int> TKAT_StylizerPattern { get; set; }
        public Nullable<int> TKAT_StylizerLine { get; set; }
        public bool TKAT_IsDefault { get; set; }
        public Nullable<System.DateTime> TKAT_DatumMut { get; set; }
        public string TKAT_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TM_Ref_Checkliste> T_TM_Ref_Checkliste { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TM_Ref_TaskArt> T_TM_Ref_TaskArt { get; set; }
    }
}

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
    
    public partial class T_TM_Ref_TaskArt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_TM_Ref_TaskArt()
        {
            this.T_TM_Ref_Checkliste = new HashSet<T_TM_Ref_Checkliste>();
            this.T_TM_Tasks_Planung = new HashSet<T_TM_Tasks_Planung>();
            this.T_TM_Tasks = new HashSet<T_TM_Tasks>();
        }
    
        public System.Guid TART_UID { get; set; }
        public int TART_MDT_ID { get; set; }
        public Nullable<int> TART_Code { get; set; }
        public string TART_Kurz_DE { get; set; }
        public string TART_Kurz_FR { get; set; }
        public string TART_Kurz_IT { get; set; }
        public string TART_Kurz_EN { get; set; }
        public string TART_Lang_DE { get; set; }
        public string TART_Lang_FR { get; set; }
        public string TART_Lang_IT { get; set; }
        public string TART_Lang_EN { get; set; }
        public int TART_Status { get; set; }
        public int TART_Sort { get; set; }
        public Nullable<int> TART_StylizerFore { get; set; }
        public Nullable<int> TART_StylizerBack { get; set; }
        public Nullable<int> TART_StylizerPattern { get; set; }
        public Nullable<int> TART_StylizerLine { get; set; }
        public bool TART_IsDefault { get; set; }
        public Nullable<System.DateTime> TART_DatumMut { get; set; }
        public string TART_DatumUser { get; set; }
        public Nullable<System.Guid> TART_TKAT_UID { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TM_Ref_Checkliste> T_TM_Ref_Checkliste { get; set; }
        public virtual T_TM_Ref_TaskKategorie T_TM_Ref_TaskKategorie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TM_Tasks_Planung> T_TM_Tasks_Planung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TM_Tasks> T_TM_Tasks { get; set; }
    }
}

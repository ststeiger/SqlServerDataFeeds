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
    
    public partial class T_TM_Ref_Abteilung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_TM_Ref_Abteilung()
        {
            this.T_TM_Tasks_Planung = new HashSet<T_TM_Tasks_Planung>();
            this.T_TM_Tasks = new HashSet<T_TM_Tasks>();
        }
    
        public System.Guid ABT_UID { get; set; }
        public Nullable<int> ABT_Code { get; set; }
        public string ABT_Kurz_DE { get; set; }
        public string ABT_Kurz_FR { get; set; }
        public string ABT_Kurz_IT { get; set; }
        public string ABT_Kurz_EN { get; set; }
        public string ABT_Lang_DE { get; set; }
        public string ABT_Lang_FR { get; set; }
        public string ABT_Lang_IT { get; set; }
        public string ABT_Lang_EN { get; set; }
        public int ABT_Status { get; set; }
        public int ABT_Sort { get; set; }
        public Nullable<int> ABT_StylizerFore { get; set; }
        public Nullable<int> ABT_StylizerBack { get; set; }
        public Nullable<int> ABT_StylizerPattern { get; set; }
        public Nullable<int> ABT_StylizerLine { get; set; }
        public bool ABT_IsDefault { get; set; }
        public Nullable<System.DateTime> ABT_DatumMut { get; set; }
        public string ABT_DatumUser { get; set; }
    
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TM_Tasks_Planung> T_TM_Tasks_Planung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TM_Tasks> T_TM_Tasks { get; set; }
    }
}

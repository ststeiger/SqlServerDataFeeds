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
    
    public partial class T_SYS_Ref_PapierFormat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_SYS_Ref_PapierFormat()
        {
            this.T_SYS_Legendenkonfiguration = new HashSet<T_SYS_Legendenkonfiguration>();
        }
    
        public System.Guid PF_UID { get; set; }
        public string PF_NormGiver { get; set; }
        public string PF_Name { get; set; }
        public string PF_CompoundSize { get; set; }
        public Nullable<decimal> PF_WidthInMM { get; set; }
        public Nullable<decimal> PF_HeightInMM { get; set; }
        public int PF_Sort { get; set; }
        public int PF_Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_SYS_Legendenkonfiguration> T_SYS_Legendenkonfiguration { get; set; }
    }
}

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
    
    public partial class T_FMS_Translation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_FMS_Translation()
        {
            this.T_FMS_Filter = new HashSet<T_FMS_Filter>();
        }
    
        public System.Guid FT_UID { get; set; }
        public string FT_Ch { get; set; }
        public string FT_De { get; set; }
        public string FT_En { get; set; }
        public string FT_Fr { get; set; }
        public string FT_It { get; set; }
        public string FT_Ru { get; set; }
        public string FT_Parameter { get; set; }
        public int FT_Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_FMS_Filter> T_FMS_Filter { get; set; }
    }
}

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
    
    public partial class T_FMS_Navigation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_FMS_Navigation()
        {
            this.T_FMS_Navigation1 = new HashSet<T_FMS_Navigation>();
            this.T_FMS_ZO_Filter = new HashSet<T_FMS_ZO_Filter>();
            this.T_FMS_ZO_Navigation_Benutzer = new HashSet<T_FMS_ZO_Navigation_Benutzer>();
            this.T_FMS_ZO_Navigation = new HashSet<T_FMS_ZO_Navigation>();
        }
    
        public System.Guid NA_UID { get; set; }
        public Nullable<System.Guid> NA_NA_UID { get; set; }
        public Nullable<System.Guid> NA_FT_UID { get; set; }
        public string NA_Color { get; set; }
        public string NA_Frame { get; set; }
        public string NA_Image { get; set; }
        public string NA_Link { get; set; }
        public string NA_NodeID { get; set; }
        public string NA_ParentNodeID { get; set; }
        public int NA_Sort { get; set; }
        public int NA_Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_FMS_Navigation> T_FMS_Navigation1 { get; set; }
        public virtual T_FMS_Navigation T_FMS_Navigation2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_FMS_ZO_Filter> T_FMS_ZO_Filter { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_FMS_ZO_Navigation_Benutzer> T_FMS_ZO_Navigation_Benutzer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_FMS_ZO_Navigation> T_FMS_ZO_Navigation { get; set; }
    }
}

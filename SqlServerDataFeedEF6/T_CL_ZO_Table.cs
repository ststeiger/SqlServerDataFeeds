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
    
    public partial class T_CL_ZO_Table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_CL_ZO_Table()
        {
            this.T_CL_ZO_Cell = new HashSet<T_CL_ZO_Cell>();
            this.T_CL_ZO_Header = new HashSet<T_CL_ZO_Header>();
        }
    
        public System.Guid ZOCLTT_UID { get; set; }
        public System.Guid ZOCLTT_CL_UID { get; set; }
        public int ZOCLTT_MDT_ID { get; set; }
        public int ZOCLTT_Status { get; set; }
        public int ZOCLTT_Sort { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_CL_Checklist T_CL_Checklist { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_CL_ZO_Cell> T_CL_ZO_Cell { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_CL_ZO_Header> T_CL_ZO_Header { get; set; }
    }
}

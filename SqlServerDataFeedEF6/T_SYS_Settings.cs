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
    
    public partial class T_SYS_Settings
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_SYS_Settings()
        {
            this.T_ZO_SYS_Settings_AP_Ref_Mandant = new HashSet<T_ZO_SYS_Settings_AP_Ref_Mandant>();
        }
    
        public System.Guid SET_UID { get; set; }
        public string SET_Code { get; set; }
        public string SET_Typ { get; set; }
        public string SET_Bezeichnung { get; set; }
        public short SET_Status { get; set; }
        public int SET_Sort { get; set; }
        public string SET_Bemerkung { get; set; }
        public string SET_Values { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_SYS_Settings_AP_Ref_Mandant> T_ZO_SYS_Settings_AP_Ref_Mandant { get; set; }
    }
}

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
    
    public partial class T_UPS_Ref_Kontoplan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_UPS_Ref_Kontoplan()
        {
            this.T_UPS_BudgetPositionen = new HashSet<T_UPS_BudgetPositionen>();
        }
    
        public System.Guid KP_UID { get; set; }
        public string KP_Code { get; set; }
        public string KP_Kurz_DE { get; set; }
        public string KP_Kurz_FR { get; set; }
        public string KP_Kurz_IT { get; set; }
        public string KP_Kurz_EN { get; set; }
        public string KP_Lang_DE { get; set; }
        public string KP_Lang_FR { get; set; }
        public string KP_Lang_IT { get; set; }
        public string KP_Lang_EN { get; set; }
        public int KP_Status { get; set; }
        public int KP_Sort { get; set; }
        public Nullable<int> KP_StylizerFore { get; set; }
        public Nullable<int> KP_StylizerBack { get; set; }
        public Nullable<int> KP_StylizerPattern { get; set; }
        public Nullable<int> KP_StylizerLine { get; set; }
        public bool KP_IsDefault { get; set; }
        public Nullable<System.DateTime> KP_DatumMut { get; set; }
        public string KP_DatumUser { get; set; }
    
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_UPS_BudgetPositionen> T_UPS_BudgetPositionen { get; set; }
    }
}

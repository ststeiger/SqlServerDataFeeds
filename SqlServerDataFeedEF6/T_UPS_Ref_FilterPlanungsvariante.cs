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
    
    public partial class T_UPS_Ref_FilterPlanungsvariante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_UPS_Ref_FilterPlanungsvariante()
        {
            this.T_UPS_BudgetPositionen = new HashSet<T_UPS_BudgetPositionen>();
        }
    
        public System.Guid FPV_UID { get; set; }
        public Nullable<int> FPV_Code { get; set; }
        public string FPV_Kurz_DE { get; set; }
        public string FPV_Kurz_FR { get; set; }
        public string FPV_Kurz_IT { get; set; }
        public string FPV_Kurz_EN { get; set; }
        public string FPV_Lang_DE { get; set; }
        public string FPV_Lang_FR { get; set; }
        public string FPV_Lang_IT { get; set; }
        public string FPV_Lang_EN { get; set; }
        public int FPV_Status { get; set; }
        public int FPV_Sort { get; set; }
        public Nullable<int> FPV_StylizerFore { get; set; }
        public Nullable<int> FPV_StylizerBack { get; set; }
        public Nullable<int> FPV_StylizerPattern { get; set; }
        public Nullable<int> FPV_StylizerLine { get; set; }
        public bool FPV_IsDefault { get; set; }
        public Nullable<System.DateTime> FPV_DatumMut { get; set; }
        public string FPV_DatumUser { get; set; }
    
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_UPS_BudgetPositionen> T_UPS_BudgetPositionen { get; set; }
    }
}

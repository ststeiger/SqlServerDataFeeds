//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SqlServerDataFeed
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_IGM_Ref_Leistungsart
    {
        public T_IGM_Ref_Leistungsart()
        {
            this.T_ZO_T_AP_Standort_T_IGM_Ref_Leistungsart = new HashSet<T_ZO_T_AP_Standort_T_IGM_Ref_Leistungsart>();
        }
    
        public System.Guid LA_UID { get; set; }
        public int LA_MDT_ID { get; set; }
        public Nullable<int> LA_Code { get; set; }
        public string LA_Kurz_DE { get; set; }
        public string LA_Kurz_FR { get; set; }
        public string LA_Kurz_IT { get; set; }
        public string LA_Kurz_EN { get; set; }
        public string LA_Lang_DE { get; set; }
        public string LA_Lang_FR { get; set; }
        public string LA_Lang_IT { get; set; }
        public string LA_Lang_EN { get; set; }
        public int LA_Status { get; set; }
        public int LA_Sort { get; set; }
        public Nullable<int> LA_StylizerFore { get; set; }
        public Nullable<int> LA_StylizerBack { get; set; }
        public Nullable<int> LA_StylizerPattern { get; set; }
        public Nullable<int> LA_StylizerLine { get; set; }
        public bool LA_IsDefault { get; set; }
        public Nullable<System.DateTime> LA_DatumMut { get; set; }
        public string LA_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        public virtual ICollection<T_ZO_T_AP_Standort_T_IGM_Ref_Leistungsart> T_ZO_T_AP_Standort_T_IGM_Ref_Leistungsart { get; set; }
    }
}

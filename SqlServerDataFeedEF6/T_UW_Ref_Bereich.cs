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
    
    public partial class T_UW_Ref_Bereich
    {
        public System.Guid UWBR_UID { get; set; }
        public int UWBR_MDT_ID { get; set; }
        public Nullable<int> UWBR_Code { get; set; }
        public string UWBR_Kurz_DE { get; set; }
        public string UWBR_Kurz_FR { get; set; }
        public string UWBR_Kurz_IT { get; set; }
        public string UWBR_Kurz_EN { get; set; }
        public string UWBR_Lang_DE { get; set; }
        public string UWBR_Lang_FR { get; set; }
        public string UWBR_Lang_IT { get; set; }
        public string UWBR_Lang_EN { get; set; }
        public int UWBR_Status { get; set; }
        public int UWBR_Sort { get; set; }
        public Nullable<int> UWBR_StylizerFore { get; set; }
        public Nullable<int> UWBR_StylizerBack { get; set; }
        public Nullable<int> UWBR_StylizerPattern { get; set; }
        public Nullable<int> UWBR_StylizerLine { get; set; }
        public bool UWBR_IsDefault { get; set; }
        public Nullable<System.DateTime> UWBR_DatumMut { get; set; }
        public string UWBR_DatumUser { get; set; }
        public Nullable<System.Guid> UWBR_UWE_UID { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        public virtual T_UW_Ref_Einheit T_UW_Ref_Einheit { get; set; }
    }
}

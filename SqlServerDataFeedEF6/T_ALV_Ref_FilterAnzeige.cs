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
    
    public partial class T_ALV_Ref_FilterAnzeige
    {
        public System.Guid FA_UID { get; set; }
        public int FA_MDT_ID { get; set; }
        public Nullable<int> FA_Code { get; set; }
        public string FA_Kurz_DE { get; set; }
        public string FA_Kurz_FR { get; set; }
        public string FA_Kurz_IT { get; set; }
        public string FA_Kurz_EN { get; set; }
        public string FA_Lang_DE { get; set; }
        public string FA_Lang_FR { get; set; }
        public string FA_Lang_IT { get; set; }
        public string FA_Lang_EN { get; set; }
        public int FA_Status { get; set; }
        public int FA_Sort { get; set; }
        public Nullable<int> FA_StylizerFore { get; set; }
        public Nullable<int> FA_StylizerBack { get; set; }
        public Nullable<int> FA_StylizerPattern { get; set; }
        public Nullable<int> FA_StylizerLine { get; set; }
        public bool FA_IsDefault { get; set; }
        public Nullable<System.DateTime> FA_DatumMut { get; set; }
        public string FA_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}
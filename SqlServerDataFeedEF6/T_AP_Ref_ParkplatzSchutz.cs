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
    
    public partial class T_AP_Ref_ParkplatzSchutz
    {
        public System.Guid PS_UID { get; set; }
        public int PS_MDT_ID { get; set; }
        public Nullable<int> PS_Code { get; set; }
        public string PS_Kurz_DE { get; set; }
        public string PS_Kurz_FR { get; set; }
        public string PS_Kurz_IT { get; set; }
        public string PS_Kurz_EN { get; set; }
        public string PS_Lang_DE { get; set; }
        public string PS_Lang_FR { get; set; }
        public string PS_Lang_IT { get; set; }
        public string PS_Lang_EN { get; set; }
        public int PS_Status { get; set; }
        public int PS_Sort { get; set; }
        public Nullable<int> PS_StylizerFore { get; set; }
        public Nullable<int> PS_StylizerBack { get; set; }
        public Nullable<int> PS_StylizerPattern { get; set; }
        public Nullable<int> PS_StylizerLine { get; set; }
        public bool PS_IsDefault { get; set; }
        public Nullable<System.DateTime> PS_DatumMut { get; set; }
        public string PS_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

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
    
    public partial class T_AP_Ref_ParkplatzLage
    {
        public System.Guid PL_UID { get; set; }
        public int PL_MDT_ID { get; set; }
        public Nullable<int> PL_Code { get; set; }
        public string PL_Kurz_DE { get; set; }
        public string PL_Kurz_FR { get; set; }
        public string PL_Kurz_IT { get; set; }
        public string PL_Kurz_EN { get; set; }
        public string PL_Lang_DE { get; set; }
        public string PL_Lang_FR { get; set; }
        public string PL_Lang_IT { get; set; }
        public string PL_Lang_EN { get; set; }
        public int PL_Status { get; set; }
        public int PL_Sort { get; set; }
        public Nullable<int> PL_StylizerFore { get; set; }
        public Nullable<int> PL_StylizerBack { get; set; }
        public Nullable<int> PL_StylizerPattern { get; set; }
        public Nullable<int> PL_StylizerLine { get; set; }
        public bool PL_IsDefault { get; set; }
        public Nullable<System.DateTime> PL_DatumMut { get; set; }
        public string PL_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}
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
    
    public partial class T_SYS_Ref_ZeitEinheiten
    {
        public System.Guid ZE_UID { get; set; }
        public int ZE_MDT_ID { get; set; }
        public Nullable<int> ZE_Code { get; set; }
        public string ZE_Kurz_DE { get; set; }
        public string ZE_Kurz_FR { get; set; }
        public string ZE_Kurz_IT { get; set; }
        public string ZE_Kurz_EN { get; set; }
        public string ZE_Lang_DE { get; set; }
        public string ZE_Lang_FR { get; set; }
        public string ZE_Lang_IT { get; set; }
        public string ZE_Lang_EN { get; set; }
        public int ZE_Status { get; set; }
        public int ZE_Sort { get; set; }
        public Nullable<int> ZE_StylizerFore { get; set; }
        public Nullable<int> ZE_StylizerBack { get; set; }
        public Nullable<int> ZE_StylizerPattern { get; set; }
        public Nullable<int> ZE_StylizerLine { get; set; }
        public bool ZE_IsDefault { get; set; }
        public Nullable<System.DateTime> ZE_DatumMut { get; set; }
        public string ZE_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

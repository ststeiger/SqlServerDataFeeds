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
    
    public partial class T_AP_Ref_AnlageKaeltemittel
    {
        public System.Guid AKM_UID { get; set; }
        public int AKM_MDT_ID { get; set; }
        public Nullable<int> AKM_Code { get; set; }
        public string AKM_Kurz_DE { get; set; }
        public string AKM_Kurz_FR { get; set; }
        public string AKM_Kurz_IT { get; set; }
        public string AKM_Kurz_EN { get; set; }
        public string AKM_Lang_DE { get; set; }
        public string AKM_Lang_FR { get; set; }
        public string AKM_Lang_IT { get; set; }
        public string AKM_Lang_EN { get; set; }
        public int AKM_Status { get; set; }
        public int AKM_Sort { get; set; }
        public Nullable<int> AKM_StylizerFore { get; set; }
        public Nullable<int> AKM_StylizerBack { get; set; }
        public Nullable<int> AKM_StylizerPattern { get; set; }
        public Nullable<int> AKM_StylizerLine { get; set; }
        public bool AKM_IsDefault { get; set; }
        public Nullable<System.DateTime> AKM_DatumMut { get; set; }
        public string AKM_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

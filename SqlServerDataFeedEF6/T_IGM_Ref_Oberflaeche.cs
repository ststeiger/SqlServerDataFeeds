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
    
    public partial class T_IGM_Ref_Oberflaeche
    {
        public System.Guid OF_UID { get; set; }
        public int OF_MDT_ID { get; set; }
        public Nullable<int> OF_Code { get; set; }
        public string OF_Kurz_DE { get; set; }
        public string OF_Kurz_FR { get; set; }
        public string OF_Kurz_IT { get; set; }
        public string OF_Kurz_EN { get; set; }
        public string OF_Lang_DE { get; set; }
        public string OF_Lang_FR { get; set; }
        public string OF_Lang_IT { get; set; }
        public string OF_Lang_EN { get; set; }
        public int OF_Status { get; set; }
        public int OF_Sort { get; set; }
        public Nullable<int> OF_StylizerFore { get; set; }
        public Nullable<int> OF_StylizerBack { get; set; }
        public Nullable<int> OF_StylizerPattern { get; set; }
        public Nullable<int> OF_StylizerLine { get; set; }
        public bool OF_IsDefault { get; set; }
        public Nullable<System.DateTime> OF_DatumMut { get; set; }
        public string OF_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

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
    
    public partial class T_AP_Ref_PersonGeschlecht
    {
        public System.Guid PG_UID { get; set; }
        public int PG_MDT_ID { get; set; }
        public Nullable<int> PG_Code { get; set; }
        public string PG_Kurz_DE { get; set; }
        public string PG_Kurz_FR { get; set; }
        public string PG_Kurz_IT { get; set; }
        public string PG_Kurz_EN { get; set; }
        public string PG_Lang_DE { get; set; }
        public string PG_Lang_FR { get; set; }
        public string PG_Lang_IT { get; set; }
        public string PG_Lang_EN { get; set; }
        public int PG_Status { get; set; }
        public int PG_Sort { get; set; }
        public Nullable<int> PG_StylizerFore { get; set; }
        public Nullable<int> PG_StylizerBack { get; set; }
        public Nullable<int> PG_StylizerPattern { get; set; }
        public Nullable<int> PG_StylizerLine { get; set; }
        public bool PG_IsDefault { get; set; }
        public Nullable<System.DateTime> PG_DatumMut { get; set; }
        public string PG_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

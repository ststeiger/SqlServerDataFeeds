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
    
    public partial class T_AP_Ref_ParkplatzTyp
    {
        public System.Guid PT_UID { get; set; }
        public int PT_MDT_ID { get; set; }
        public Nullable<int> PT_Code { get; set; }
        public string PT_Kurz_DE { get; set; }
        public string PT_Kurz_FR { get; set; }
        public string PT_Kurz_IT { get; set; }
        public string PT_Kurz_EN { get; set; }
        public string PT_Lang_DE { get; set; }
        public string PT_Lang_FR { get; set; }
        public string PT_Lang_IT { get; set; }
        public string PT_Lang_EN { get; set; }
        public int PT_Status { get; set; }
        public int PT_Sort { get; set; }
        public Nullable<int> PT_StylizerFore { get; set; }
        public Nullable<int> PT_StylizerBack { get; set; }
        public Nullable<int> PT_StylizerPattern { get; set; }
        public Nullable<int> PT_StylizerLine { get; set; }
        public bool PT_IsDefault { get; set; }
        public Nullable<System.DateTime> PT_DatumMut { get; set; }
        public string PT_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

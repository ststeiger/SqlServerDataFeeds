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
    
    public partial class T_AP_Ref_Freigabetyp
    {
        public System.Guid FGT_UID { get; set; }
        public int FGT_MDT_ID { get; set; }
        public string FGT_Code { get; set; }
        public string FGT_Kurz_DE { get; set; }
        public string FGT_Kurz_FR { get; set; }
        public string FGT_Kurz_IT { get; set; }
        public string FGT_Kurz_EN { get; set; }
        public string FGT_Lang_DE { get; set; }
        public string FGT_Lang_FR { get; set; }
        public string FGT_Lang_IT { get; set; }
        public string FGT_Lang_EN { get; set; }
        public int FGT_Status { get; set; }
        public int FGT_Sort { get; set; }
        public Nullable<int> FGT_StylizerFore { get; set; }
        public Nullable<int> FGT_StylizerBack { get; set; }
        public Nullable<int> FGT_StylizerPattern { get; set; }
        public Nullable<int> FGT_StylizerLine { get; set; }
        public bool FGT_IsDefault { get; set; }
        public Nullable<System.DateTime> FGT_DatumMut { get; set; }
        public string FGT_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}
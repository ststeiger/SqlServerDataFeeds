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
    
    public partial class T_DMS_Ref_Metadaten_1
    {
        public System.Guid MD1_UID { get; set; }
        public Nullable<int> MD1_Code { get; set; }
        public string MD1_Kurz_DE { get; set; }
        public string MD1_Kurz_FR { get; set; }
        public string MD1_Kurz_IT { get; set; }
        public string MD1_Kurz_EN { get; set; }
        public string MD1_Lang_DE { get; set; }
        public string MD1_Lang_FR { get; set; }
        public string MD1_Lang_IT { get; set; }
        public string MD1_Lang_EN { get; set; }
        public int MD1_Status { get; set; }
        public int MD1_Sort { get; set; }
        public Nullable<int> MD1_StylizerFore { get; set; }
        public Nullable<int> MD1_StylizerBack { get; set; }
        public Nullable<int> MD1_StylizerPattern { get; set; }
        public Nullable<int> MD1_StylizerLine { get; set; }
        public bool MD1_IsDefault { get; set; }
        public Nullable<System.DateTime> MD1_DatumMut { get; set; }
        public string MD1_DatumUser { get; set; }
    
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

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
    
    public partial class T_DMS_Ref_Metadaten_5
    {
        public System.Guid MD5_UID { get; set; }
        public Nullable<int> MD5_Code { get; set; }
        public string MD5_Kurz_DE { get; set; }
        public string MD5_Kurz_FR { get; set; }
        public string MD5_Kurz_IT { get; set; }
        public string MD5_Kurz_EN { get; set; }
        public string MD5_Lang_DE { get; set; }
        public string MD5_Lang_FR { get; set; }
        public string MD5_Lang_IT { get; set; }
        public string MD5_Lang_EN { get; set; }
        public int MD5_Status { get; set; }
        public int MD5_Sort { get; set; }
        public Nullable<int> MD5_StylizerFore { get; set; }
        public Nullable<int> MD5_StylizerBack { get; set; }
        public Nullable<int> MD5_StylizerPattern { get; set; }
        public Nullable<int> MD5_StylizerLine { get; set; }
        public bool MD5_IsDefault { get; set; }
        public Nullable<System.DateTime> MD5_DatumMut { get; set; }
        public string MD5_DatumUser { get; set; }
    
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}
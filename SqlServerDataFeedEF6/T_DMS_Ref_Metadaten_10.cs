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
    
    public partial class T_DMS_Ref_Metadaten_10
    {
        public System.Guid MD10_UID { get; set; }
        public Nullable<int> MD10_Code { get; set; }
        public string MD10_Kurz_DE { get; set; }
        public string MD10_Kurz_FR { get; set; }
        public string MD10_Kurz_IT { get; set; }
        public string MD10_Kurz_EN { get; set; }
        public string MD10_Lang_DE { get; set; }
        public string MD10_Lang_FR { get; set; }
        public string MD10_Lang_IT { get; set; }
        public string MD10_Lang_EN { get; set; }
        public int MD10_Status { get; set; }
        public int MD10_Sort { get; set; }
        public Nullable<int> MD10_StylizerFore { get; set; }
        public Nullable<int> MD10_StylizerBack { get; set; }
        public Nullable<int> MD10_StylizerPattern { get; set; }
        public Nullable<int> MD10_StylizerLine { get; set; }
        public bool MD10_IsDefault { get; set; }
        public Nullable<System.DateTime> MD10_DatumMut { get; set; }
        public string MD10_DatumUser { get; set; }
    
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}
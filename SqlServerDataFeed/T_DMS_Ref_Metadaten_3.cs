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
    
    public partial class T_DMS_Ref_Metadaten_3
    {
        public System.Guid MD3_UID { get; set; }
        public Nullable<int> MD3_Code { get; set; }
        public string MD3_Kurz_DE { get; set; }
        public string MD3_Kurz_FR { get; set; }
        public string MD3_Kurz_IT { get; set; }
        public string MD3_Kurz_EN { get; set; }
        public string MD3_Lang_DE { get; set; }
        public string MD3_Lang_FR { get; set; }
        public string MD3_Lang_IT { get; set; }
        public string MD3_Lang_EN { get; set; }
        public int MD3_Status { get; set; }
        public int MD3_Sort { get; set; }
        public Nullable<int> MD3_StylizerFore { get; set; }
        public Nullable<int> MD3_StylizerBack { get; set; }
        public Nullable<int> MD3_StylizerPattern { get; set; }
        public Nullable<int> MD3_StylizerLine { get; set; }
        public bool MD3_IsDefault { get; set; }
        public Nullable<System.DateTime> MD3_DatumMut { get; set; }
        public string MD3_DatumUser { get; set; }
    
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}
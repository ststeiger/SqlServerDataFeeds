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
    
    public partial class T_AP_Ref_Emailtext
    {
        public System.Guid ET_UID { get; set; }
        public Nullable<System.Guid> ET_ETC_UID { get; set; }
        public string ET_Code { get; set; }
        public int ET_Status { get; set; }
        public int ET_Sort { get; set; }
        public bool ET_IsDefault { get; set; }
        public Nullable<int> ET_StylizerBack { get; set; }
        public Nullable<int> ET_StylizerFore { get; set; }
        public Nullable<int> ET_StylizerPattern { get; set; }
        public int ET_MDT_ID { get; set; }
        public string ET_Title_de { get; set; }
        public string ET_Title_fr { get; set; }
        public string ET_Title_it { get; set; }
        public string ET_Title_en { get; set; }
        public string ET_Text_de { get; set; }
        public string ET_Text_fr { get; set; }
        public string ET_Text_it { get; set; }
        public string ET_Text_en { get; set; }
        public Nullable<int> ET_StylizerLine { get; set; }
    
        public virtual T_AP_Ref_EmailtextKategorie T_AP_Ref_EmailtextKategorie { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

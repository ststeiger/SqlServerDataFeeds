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
    
    public partial class T_AP_Ref_Email_Placeholder
    {
        public System.Guid EP_UID { get; set; }
        public System.Guid EP_ETC_UID { get; set; }
        public string EP_Code { get; set; }
        public int EP_Status { get; set; }
        public int EP_Sort { get; set; }
        public string EP_Kurz_de { get; set; }
        public string EP_Kurz_fr { get; set; }
        public string EP_Kurz_it { get; set; }
        public string EP_Kurz_en { get; set; }
        public string EP_PlaceholderText { get; set; }
        public string EP_Table { get; set; }
        public string EP_Feld { get; set; }
    
        public virtual T_AP_Ref_EmailtextKategorie T_AP_Ref_EmailtextKategorie { get; set; }
    }
}

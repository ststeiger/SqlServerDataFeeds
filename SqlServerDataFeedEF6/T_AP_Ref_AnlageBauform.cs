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
    
    public partial class T_AP_Ref_AnlageBauform
    {
        public System.Guid ABF_UID { get; set; }
        public int ABF_MDT_ID { get; set; }
        public Nullable<int> ABF_Code { get; set; }
        public string ABF_Kurz_DE { get; set; }
        public string ABF_Kurz_FR { get; set; }
        public string ABF_Kurz_IT { get; set; }
        public string ABF_Kurz_EN { get; set; }
        public string ABF_Lang_DE { get; set; }
        public string ABF_Lang_FR { get; set; }
        public string ABF_Lang_IT { get; set; }
        public string ABF_Lang_EN { get; set; }
        public int ABF_Status { get; set; }
        public int ABF_Sort { get; set; }
        public Nullable<int> ABF_StylizerFore { get; set; }
        public Nullable<int> ABF_StylizerBack { get; set; }
        public Nullable<int> ABF_StylizerPattern { get; set; }
        public Nullable<int> ABF_StylizerLine { get; set; }
        public bool ABF_IsDefault { get; set; }
        public Nullable<System.DateTime> ABF_DatumMut { get; set; }
        public string ABF_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

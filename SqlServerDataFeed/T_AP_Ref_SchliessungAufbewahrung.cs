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
    
    public partial class T_AP_Ref_SchliessungAufbewahrung
    {
        public System.Guid SA_UID { get; set; }
        public int SA_MDT_ID { get; set; }
        public string SA_Code { get; set; }
        public string SA_Kurz_DE { get; set; }
        public string SA_Kurz_FR { get; set; }
        public string SA_Kurz_IT { get; set; }
        public string SA_Kurz_EN { get; set; }
        public string SA_Lang_DE { get; set; }
        public string SA_Lang_FR { get; set; }
        public string SA_Lang_IT { get; set; }
        public string SA_Lang_EN { get; set; }
        public int SA_Status { get; set; }
        public int SA_Sort { get; set; }
        public Nullable<int> SA_StylizerFore { get; set; }
        public Nullable<int> SA_StylizerBack { get; set; }
        public Nullable<int> SA_StylizerPattern { get; set; }
        public Nullable<int> SA_StylizerLine { get; set; }
        public bool SA_IsDefault { get; set; }
        public Nullable<System.DateTime> SA_DatumMut { get; set; }
        public string SA_DatumUser { get; set; }
        public bool SA_IsZylinder { get; set; }
        public bool SA_IsSchluessel { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}
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
    
    public partial class T_AP_Ref_Mandant_Logo
    {
        public System.Guid LOGO_UID { get; set; }
        public Nullable<int> LOGO_MDT_ID { get; set; }
        public string LOGO_MDT_Lang_DE { get; set; }
        public string LOGO_Path { get; set; }
        public string LOGO_Filename { get; set; }
        public string LOGO_Name { get; set; }
        public string LOGO_Code { get; set; }
        public string LOGO_Kurz_DE { get; set; }
        public string LOGO_Kurz_FR { get; set; }
        public string LOGO_Kurz_IT { get; set; }
        public string LOGO_Kurz_EN { get; set; }
        public string LOGO_Lang_DE { get; set; }
        public string LOGO_Lang_FR { get; set; }
        public string LOGO_Lang_IT { get; set; }
        public string LOGO_Lang_EN { get; set; }
        public int LOGO_Width { get; set; }
        public int LOGO_Height { get; set; }
        public Nullable<double> LOGO_PaddingLeft { get; set; }
        public Nullable<double> LOGO_PaddingRight { get; set; }
        public Nullable<double> LOGO_PaddingTop { get; set; }
        public Nullable<double> LOGO_PaddingBottom { get; set; }
        public bool LOGO_Hide { get; set; }
        public System.DateTime LOGO_DatumVon { get; set; }
        public System.DateTime LOGO_DatumBis { get; set; }
        public int LOGO_Status { get; set; }
        public int LOGO_Sort { get; set; }
        public Nullable<int> LOGO_StylizerFore { get; set; }
        public Nullable<int> LOGO_StylizerBack { get; set; }
        public Nullable<int> LOGO_StylizerPattern { get; set; }
        public Nullable<int> LOGO_StylizerLine { get; set; }
        public bool LOGO_IsDefault { get; set; }
        public Nullable<System.DateTime> LOGO_DatumMut { get; set; }
        public string LOGO_DatumUser { get; set; }
    
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

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
    
    public partial class T_AP_Ref_KunstProvenienz
    {
        public System.Guid KPRO_UID { get; set; }
        public int KPRO_MDT_ID { get; set; }
        public string KPRO_Code { get; set; }
        public string KPRO_Kurz_DE { get; set; }
        public string KPRO_Kurz_FR { get; set; }
        public string KPRO_Kurz_IT { get; set; }
        public string KPRO_Kurz_EN { get; set; }
        public string KPRO_Lang_DE { get; set; }
        public string KPRO_Lang_FR { get; set; }
        public string KPRO_Lang_IT { get; set; }
        public string KPRO_Lang_EN { get; set; }
        public int KPRO_Status { get; set; }
        public int KPRO_Sort { get; set; }
        public Nullable<int> KPRO_StylizerFore { get; set; }
        public Nullable<int> KPRO_StylizerBack { get; set; }
        public Nullable<int> KPRO_StylizerPattern { get; set; }
        public Nullable<int> KPRO_StylizerLine { get; set; }
        public bool KPRO_IsDefault { get; set; }
        public Nullable<System.DateTime> KPRO_DatumMut { get; set; }
        public string KPRO_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
    }
}

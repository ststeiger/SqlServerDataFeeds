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
    
    public partial class T_AP_Ref_Fluchtwegmarkierung
    {
        public T_AP_Ref_Fluchtwegmarkierung()
        {
            this.T_AP_Raum = new HashSet<T_AP_Raum>();
            this.T_AP_Zone = new HashSet<T_AP_Zone>();
        }
    
        public System.Guid FM_UID { get; set; }
        public int FM_MDT_ID { get; set; }
        public Nullable<int> FM_Code { get; set; }
        public string FM_Kurz_DE { get; set; }
        public string FM_Kurz_FR { get; set; }
        public string FM_Kurz_IT { get; set; }
        public string FM_Kurz_EN { get; set; }
        public string FM_Lang_DE { get; set; }
        public string FM_Lang_FR { get; set; }
        public string FM_Lang_IT { get; set; }
        public string FM_Lang_EN { get; set; }
        public int FM_Status { get; set; }
        public int FM_Sort { get; set; }
        public Nullable<int> FM_StylizerFore { get; set; }
        public Nullable<int> FM_StylizerBack { get; set; }
        public Nullable<int> FM_StylizerPattern { get; set; }
        public Nullable<int> FM_StylizerLine { get; set; }
        public bool FM_IsDefault { get; set; }
        public Nullable<System.DateTime> FM_DatumMut { get; set; }
        public string FM_DatumUser { get; set; }
    
        public virtual ICollection<T_AP_Raum> T_AP_Raum { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        public virtual ICollection<T_AP_Zone> T_AP_Zone { get; set; }
    }
}

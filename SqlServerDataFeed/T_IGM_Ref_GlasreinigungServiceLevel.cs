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
    
    public partial class T_IGM_Ref_GlasreinigungServiceLevel
    {
        public T_IGM_Ref_GlasreinigungServiceLevel()
        {
            this.T_AP_Raum = new HashSet<T_AP_Raum>();
        }
    
        public System.Guid GSL_UID { get; set; }
        public int GSL_MDT_ID { get; set; }
        public Nullable<int> GSL_Code { get; set; }
        public string GSL_Kurz_DE { get; set; }
        public string GSL_Kurz_FR { get; set; }
        public string GSL_Kurz_IT { get; set; }
        public string GSL_Kurz_EN { get; set; }
        public string GSL_Lang_DE { get; set; }
        public string GSL_Lang_FR { get; set; }
        public string GSL_Lang_IT { get; set; }
        public string GSL_Lang_EN { get; set; }
        public int GSL_Status { get; set; }
        public int GSL_Sort { get; set; }
        public Nullable<int> GSL_StylizerFore { get; set; }
        public Nullable<int> GSL_StylizerBack { get; set; }
        public Nullable<int> GSL_StylizerPattern { get; set; }
        public Nullable<int> GSL_StylizerLine { get; set; }
        public bool GSL_IsDefault { get; set; }
        public Nullable<System.DateTime> GSL_DatumMut { get; set; }
        public string GSL_DatumUser { get; set; }
    
        public virtual ICollection<T_AP_Raum> T_AP_Raum { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

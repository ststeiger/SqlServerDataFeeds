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
    
    public partial class T_AP_Ref_MobiliarMaterial
    {
        public T_AP_Ref_MobiliarMaterial()
        {
            this.T_AP_Ref_MobiliarBibliothek = new HashSet<T_AP_Ref_MobiliarBibliothek>();
        }
    
        public System.Guid MM_UID { get; set; }
        public int MM_MDT_ID { get; set; }
        public Nullable<int> MM_Code { get; set; }
        public string MM_Kurz_DE { get; set; }
        public string MM_Kurz_FR { get; set; }
        public string MM_Kurz_IT { get; set; }
        public string MM_Kurz_EN { get; set; }
        public string MM_Lang_DE { get; set; }
        public string MM_Lang_FR { get; set; }
        public string MM_Lang_IT { get; set; }
        public string MM_Lang_EN { get; set; }
        public int MM_Status { get; set; }
        public int MM_Sort { get; set; }
        public Nullable<int> MM_StylizerFore { get; set; }
        public Nullable<int> MM_StylizerBack { get; set; }
        public Nullable<int> MM_StylizerPattern { get; set; }
        public Nullable<int> MM_StylizerLine { get; set; }
        public bool MM_IsDefault { get; set; }
        public Nullable<System.DateTime> MM_DatumMut { get; set; }
        public string MM_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual ICollection<T_AP_Ref_MobiliarBibliothek> T_AP_Ref_MobiliarBibliothek { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}
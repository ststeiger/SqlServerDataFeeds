//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SqlServerDataFeed
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_AP_Ref_Layerset
    {
        public System.Guid LY_UID { get; set; }
        public int LY_MDT_ID { get; set; }
        public Nullable<int> LY_Code { get; set; }
        public string LY_Kurz_DE { get; set; }
        public string LY_Kurz_FR { get; set; }
        public string LY_Kurz_IT { get; set; }
        public string LY_Kurz_EN { get; set; }
        public string LY_Lang_DE { get; set; }
        public string LY_Lang_FR { get; set; }
        public string LY_Lang_IT { get; set; }
        public string LY_Lang_EN { get; set; }
        public int LY_Status { get; set; }
        public int LY_Sort { get; set; }
        public Nullable<int> LY_StylizerFore { get; set; }
        public Nullable<int> LY_StylizerBack { get; set; }
        public Nullable<int> LY_StylizerPattern { get; set; }
        public Nullable<int> LY_StylizerLine { get; set; }
        public bool LY_IsDefault { get; set; }
        public Nullable<System.DateTime> LY_DatumMut { get; set; }
        public string LY_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
    }
}

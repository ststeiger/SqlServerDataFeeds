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
    
    public partial class T_AP_Ref_AnlageRueckkuehlung
    {
        public System.Guid ARK_UID { get; set; }
        public int ARK_MDT_ID { get; set; }
        public Nullable<int> ARK_Code { get; set; }
        public string ARK_Kurz_DE { get; set; }
        public string ARK_Kurz_FR { get; set; }
        public string ARK_Kurz_IT { get; set; }
        public string ARK_Kurz_EN { get; set; }
        public string ARK_Lang_DE { get; set; }
        public string ARK_Lang_FR { get; set; }
        public string ARK_Lang_IT { get; set; }
        public string ARK_Lang_EN { get; set; }
        public int ARK_Status { get; set; }
        public int ARK_Sort { get; set; }
        public Nullable<int> ARK_StylizerFore { get; set; }
        public Nullable<int> ARK_StylizerBack { get; set; }
        public Nullable<int> ARK_StylizerPattern { get; set; }
        public Nullable<int> ARK_StylizerLine { get; set; }
        public bool ARK_IsDefault { get; set; }
        public Nullable<System.DateTime> ARK_DatumMut { get; set; }
        public string ARK_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
    }
}

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
    
    public partial class T_AP_Ref_ZaehlerKategorie
    {
        public System.Guid ZKAT_UID { get; set; }
        public int ZKAT_MDT_ID { get; set; }
        public Nullable<int> ZKAT_Code { get; set; }
        public string ZKAT_Kurz_DE { get; set; }
        public string ZKAT_Kurz_FR { get; set; }
        public string ZKAT_Kurz_IT { get; set; }
        public string ZKAT_Kurz_EN { get; set; }
        public string ZKAT_Lang_DE { get; set; }
        public string ZKAT_Lang_FR { get; set; }
        public string ZKAT_Lang_IT { get; set; }
        public string ZKAT_Lang_EN { get; set; }
        public int ZKAT_Status { get; set; }
        public int ZKAT_Sort { get; set; }
        public Nullable<int> ZKAT_StylizerFore { get; set; }
        public Nullable<int> ZKAT_StylizerBack { get; set; }
        public Nullable<int> ZKAT_StylizerPattern { get; set; }
        public Nullable<int> ZKAT_StylizerLine { get; set; }
        public bool ZKAT_IsDefault { get; set; }
        public Nullable<System.DateTime> ZKAT_DatumMut { get; set; }
        public string ZKAT_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
    }
}

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
    
    public partial class T_AP_Ref_MitarbeiterAusruestung
    {
        public System.Guid MAA_UID { get; set; }
        public int MAA_MDT_ID { get; set; }
        public Nullable<int> MAA_Code { get; set; }
        public string MAA_Kurz_DE { get; set; }
        public string MAA_Kurz_FR { get; set; }
        public string MAA_Kurz_IT { get; set; }
        public string MAA_Kurz_EN { get; set; }
        public string MAA_Lang_DE { get; set; }
        public string MAA_Lang_FR { get; set; }
        public string MAA_Lang_IT { get; set; }
        public string MAA_Lang_EN { get; set; }
        public int MAA_Status { get; set; }
        public int MAA_Sort { get; set; }
        public Nullable<int> MAA_StylizerFore { get; set; }
        public Nullable<int> MAA_StylizerBack { get; set; }
        public Nullable<int> MAA_StylizerPattern { get; set; }
        public Nullable<int> MAA_StylizerLine { get; set; }
        public bool MAA_IsDefault { get; set; }
        public Nullable<System.DateTime> MAA_DatumMut { get; set; }
        public string MAA_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
    }
}

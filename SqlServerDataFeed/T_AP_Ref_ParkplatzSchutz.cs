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
    
    public partial class T_AP_Ref_ParkplatzSchutz
    {
        public System.Guid PS_UID { get; set; }
        public Nullable<int> PS_Code { get; set; }
        public string PS_Kurz_DE { get; set; }
        public string PS_Kurz_FR { get; set; }
        public string PS_Kurz_IT { get; set; }
        public string PS_Kurz_EN { get; set; }
        public string PS_Lang_DE { get; set; }
        public string PS_Lang_FR { get; set; }
        public string PS_Lang_IT { get; set; }
        public string PS_Lang_EN { get; set; }
        public int PS_Status { get; set; }
        public int PS_Sort { get; set; }
        public Nullable<int> PS_StylizerBack { get; set; }
        public Nullable<int> PS_StylizerPattern { get; set; }
        public Nullable<int> PS_StylizerLine { get; set; }
        public bool PS_IsDefault { get; set; }
        public Nullable<System.DateTime> PS_DatumMut { get; set; }
        public string PS_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

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
    
    public partial class T_AP_Ref_AnlageEnergietraeger
    {
        public System.Guid AET_UID { get; set; }
        public Nullable<int> AET_Code { get; set; }
        public string AET_Kurz_DE { get; set; }
        public string AET_Kurz_FR { get; set; }
        public string AET_Kurz_IT { get; set; }
        public string AET_Kurz_EN { get; set; }
        public string AET_Lang_DE { get; set; }
        public string AET_Lang_FR { get; set; }
        public string AET_Lang_IT { get; set; }
        public string AET_Lang_EN { get; set; }
        public int AET_Status { get; set; }
        public int AET_Sort { get; set; }
        public Nullable<int> AET_StylizerBack { get; set; }
        public Nullable<int> AET_StylizerPattern { get; set; }
        public Nullable<int> AET_StylizerLine { get; set; }
        public bool AET_IsDefault { get; set; }
        public Nullable<System.DateTime> AET_DatumMut { get; set; }
        public string AET_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

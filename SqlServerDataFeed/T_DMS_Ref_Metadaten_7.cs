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
    
    public partial class T_DMS_Ref_Metadaten_7
    {
        public System.Guid MD7_UID { get; set; }
        public Nullable<int> MD7_Code { get; set; }
        public string MD7_Kurz_DE { get; set; }
        public string MD7_Kurz_FR { get; set; }
        public string MD7_Kurz_IT { get; set; }
        public string MD7_Kurz_EN { get; set; }
        public string MD7_Lang_DE { get; set; }
        public string MD7_Lang_FR { get; set; }
        public string MD7_Lang_IT { get; set; }
        public string MD7_Lang_EN { get; set; }
        public int MD7_Status { get; set; }
        public int MD7_Sort { get; set; }
        public Nullable<int> MD7_StylizerBack { get; set; }
        public Nullable<int> MD7_StylizerPattern { get; set; }
        public Nullable<int> MD7_StylizerLine { get; set; }
        public bool MD7_IsDefault { get; set; }
        public Nullable<System.DateTime> MD7_DatumMut { get; set; }
        public string MD7_DatumUser { get; set; }
    
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

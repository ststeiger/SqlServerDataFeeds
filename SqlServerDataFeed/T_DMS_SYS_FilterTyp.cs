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
    
    public partial class T_DMS_SYS_FilterTyp
    {
        public System.Guid SYS_FT_UID { get; set; }
        public Nullable<int> SYS_FT_Code { get; set; }
        public string SYS_FT_Kurz_DE { get; set; }
        public string SYS_FT_Kurz_FR { get; set; }
        public string SYS_FT_Kurz_IT { get; set; }
        public string SYS_FT_Kurz_EN { get; set; }
        public string SYS_FT_Lang_DE { get; set; }
        public string SYS_FT_Lang_FR { get; set; }
        public string SYS_FT_Lang_IT { get; set; }
        public string SYS_FT_Lang_EN { get; set; }
        public int SYS_FT_Status { get; set; }
        public int SYS_FT_Sort { get; set; }
        public Nullable<int> SYS_FT_StylizerBack { get; set; }
        public Nullable<int> SYS_FT_StylizerPattern { get; set; }
        public Nullable<int> SYS_FT_StylizerLine { get; set; }
        public bool SYS_FT_IsDefault { get; set; }
        public Nullable<System.DateTime> SYS_FT_DatumMut { get; set; }
        public string SYS_FT_DatumUser { get; set; }
    
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

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
    
    public partial class T_DMS_Ref_DokumentGruppeGebaeude
    {
        public System.Guid DGG_UID { get; set; }
        public Nullable<int> DGG_Code { get; set; }
        public string DGG_Kurz_DE { get; set; }
        public string DGG_Kurz_FR { get; set; }
        public string DGG_Kurz_IT { get; set; }
        public string DGG_Kurz_EN { get; set; }
        public string DGG_Lang_DE { get; set; }
        public string DGG_Lang_FR { get; set; }
        public string DGG_Lang_IT { get; set; }
        public string DGG_Lang_EN { get; set; }
        public int DGG_Status { get; set; }
        public int DGG_Sort { get; set; }
        public Nullable<int> DGG_StylizerBack { get; set; }
        public Nullable<int> DGG_StylizerPattern { get; set; }
        public Nullable<int> DGG_StylizerLine { get; set; }
        public bool DGG_IsDefault { get; set; }
        public Nullable<System.DateTime> DGG_DatumMut { get; set; }
        public string DGG_DatumUser { get; set; }
    
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

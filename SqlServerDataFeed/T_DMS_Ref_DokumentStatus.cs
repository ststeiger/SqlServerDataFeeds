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
    
    public partial class T_DMS_Ref_DokumentStatus
    {
        public System.Guid DS_UID { get; set; }
        public string DS_PossibleProc { get; set; }
        public Nullable<int> DS_Code { get; set; }
        public bool DS_SetSpecialRights { get; set; }
        public bool DS_AllowUploadOnlyUser { get; set; }
        public string DS_Kurz_DE { get; set; }
        public string DS_Kurz_FR { get; set; }
        public string DS_Kurz_IT { get; set; }
        public string DS_Kurz_EN { get; set; }
        public string DS_Lang_DE { get; set; }
        public string DS_Lang_FR { get; set; }
        public string DS_Lang_IT { get; set; }
        public string DS_Lang_EN { get; set; }
        public int DS_Status { get; set; }
        public int DS_Sort { get; set; }
        public Nullable<int> DS_StylizerBack { get; set; }
        public Nullable<int> DS_StylizerPattern { get; set; }
        public Nullable<int> DS_StylizerLine { get; set; }
        public bool DS_IsDefault { get; set; }
        public Nullable<System.DateTime> DS_DatumMut { get; set; }
        public string DS_DatumUser { get; set; }
    
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

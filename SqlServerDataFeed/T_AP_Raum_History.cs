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
    
    public partial class T_AP_Raum_History
    {
        public System.Guid HIRM_UID { get; set; }
        public System.Guid HIRM_Entry_UID { get; set; }
        public System.DateTime HIRM_Datum { get; set; }
        public string HIRM_User { get; set; }
        public string HIRM_Feld_DE { get; set; }
        public string HIRM_Feld_FR { get; set; }
        public string HIRM_Feld_IT { get; set; }
        public string HIRM_Feld_EN { get; set; }
        public string HIRM_Alt_DE { get; set; }
        public string HIRM_Alt_FR { get; set; }
        public string HIRM_Alt_IT { get; set; }
        public string HIRM_Alt_EN { get; set; }
        public string HIRM_Neu_DE { get; set; }
        public string HIRM_Neu_FR { get; set; }
        public string HIRM_Neu_IT { get; set; }
        public string HIRM_Neu_EN { get; set; }
        public bool HIRM_IsNew { get; set; }
        public bool HIRM_IsChange { get; set; }
        public bool HIRM_IsUpload { get; set; }
        public bool HIRM_IsDownload { get; set; }
        public bool HIRM_IsClient { get; set; }
        public int HIRM_Version { get; set; }
        public bool HIRM_IsGeloescht { get; set; }
        public int HIRM_Status { get; set; }
        public string HIRM_Filter1 { get; set; }
        public string HIRM_Filter2 { get; set; }
        public bool HIRM_IsAction { get; set; }
        public bool HIRM_IsSubEntry { get; set; }
    
        public virtual T_AP_Raum T_AP_Raum { get; set; }
    }
}

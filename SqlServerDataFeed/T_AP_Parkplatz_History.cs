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
    
    public partial class T_AP_Parkplatz_History
    {
        public System.Guid HIPP_UID { get; set; }
        public System.Guid HIPP_PP_UID { get; set; }
        public System.Guid HIPP_Entry_UID { get; set; }
        public System.DateTime HIPP_Datum { get; set; }
        public string HIPP_User { get; set; }
        public string HIPP_Feld_DE { get; set; }
        public string HIPP_Feld_FR { get; set; }
        public string HIPP_Feld_IT { get; set; }
        public string HIPP_Feld_EN { get; set; }
        public string HIPP_Alt_DE { get; set; }
        public string HIPP_Alt_FR { get; set; }
        public string HIPP_Alt_IT { get; set; }
        public string HIPP_Alt_EN { get; set; }
        public string HIPP_Neu_DE { get; set; }
        public string HIPP_Neu_FR { get; set; }
        public string HIPP_Neu_IT { get; set; }
        public string HIPP_Neu_EN { get; set; }
        public bool HIPP_IsNew { get; set; }
        public bool HIPP_IsChange { get; set; }
        public bool HIPP_IsUpload { get; set; }
        public bool HIPP_IsDownload { get; set; }
        public bool HIPP_IsClient { get; set; }
        public int HIPP_Version { get; set; }
        public bool HIPP_IsGeloescht { get; set; }
        public int HIPP_Status { get; set; }
        public string HIPP_Filter1 { get; set; }
        public string HIPP_Filter2 { get; set; }
        public bool HIPP_IsAction { get; set; }
        public bool HIPP_IsSubEntry { get; set; }
    
        public virtual T_AP_Parkplatz T_AP_Parkplatz { get; set; }
    }
}

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
    
    public partial class T_AP_Anschluss_History
    {
        public System.Guid HIAN_UID { get; set; }
        public System.Guid HIAN_AN_UID { get; set; }
        public System.Guid HIAN_Entry_UID { get; set; }
        public System.DateTime HIAN_Datum { get; set; }
        public string HIAN_User { get; set; }
        public string HIAN_Feld_DE { get; set; }
        public string HIAN_Feld_FR { get; set; }
        public string HIAN_Feld_IT { get; set; }
        public string HIAN_Feld_EN { get; set; }
        public string HIAN_Alt_DE { get; set; }
        public string HIAN_Alt_FR { get; set; }
        public string HIAN_Alt_IT { get; set; }
        public string HIAN_Alt_EN { get; set; }
        public string HIAN_Neu_DE { get; set; }
        public string HIAN_Neu_FR { get; set; }
        public string HIAN_Neu_IT { get; set; }
        public string HIAN_Neu_EN { get; set; }
        public bool HIAN_IsNew { get; set; }
        public bool HIAN_IsChange { get; set; }
        public bool HIAN_IsUpload { get; set; }
        public bool HIAN_IsDownload { get; set; }
        public bool HIAN_IsClient { get; set; }
        public int HIAN_Version { get; set; }
        public bool HIAN_IsGeloescht { get; set; }
        public int HIAN_Status { get; set; }
        public string HIAN_Filter1 { get; set; }
        public string HIAN_Filter2 { get; set; }
        public bool HIAN_IsAction { get; set; }
        public bool HIAN_IsSubEntry { get; set; }
    
        public virtual T_AP_Anschluss T_AP_Anschluss { get; set; }
    }
}

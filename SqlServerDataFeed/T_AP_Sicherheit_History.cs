//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SqlServerDataFeed
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_AP_Sicherheit_History
    {
        public System.Guid HISH_UID { get; set; }
        public System.Guid HISH_SH_UID { get; set; }
        public System.Guid HISH_Entry_UID { get; set; }
        public System.DateTime HISH_Datum { get; set; }
        public string HISH_User { get; set; }
        public string HISH_Feld_DE { get; set; }
        public string HISH_Feld_FR { get; set; }
        public string HISH_Feld_IT { get; set; }
        public string HISH_Feld_EN { get; set; }
        public string HISH_Alt_DE { get; set; }
        public string HISH_Alt_FR { get; set; }
        public string HISH_Alt_IT { get; set; }
        public string HISH_Alt_EN { get; set; }
        public string HISH_Neu_DE { get; set; }
        public string HISH_Neu_FR { get; set; }
        public string HISH_Neu_IT { get; set; }
        public string HISH_Neu_EN { get; set; }
        public bool HISH_IsNew { get; set; }
        public bool HISH_IsChange { get; set; }
        public bool HISH_IsUpload { get; set; }
        public bool HISH_IsDownload { get; set; }
        public bool HISH_IsClient { get; set; }
        public int HISH_Version { get; set; }
        public bool HISH_IsGeloescht { get; set; }
        public int HISH_Status { get; set; }
        public string HISH_Filter1 { get; set; }
        public string HISH_Filter2 { get; set; }
        public bool HISH_IsAction { get; set; }
        public bool HISH_IsSubEntry { get; set; }
    
        public virtual T_AP_Sicherheit T_AP_Sicherheit { get; set; }
    }
}
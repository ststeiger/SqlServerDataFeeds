//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SqlServerDataFeedEF6
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_AP_Standort_History
    {
        public System.Guid HISO_UID { get; set; }
        public System.Guid HISO_SO_UID { get; set; }
        public System.Guid HISO_Entry_UID { get; set; }
        public System.DateTime HISO_Datum { get; set; }
        public string HISO_User { get; set; }
        public string HISO_Feld_DE { get; set; }
        public string HISO_Feld_FR { get; set; }
        public string HISO_Feld_IT { get; set; }
        public string HISO_Feld_EN { get; set; }
        public string HISO_Alt_DE { get; set; }
        public string HISO_Alt_FR { get; set; }
        public string HISO_Alt_IT { get; set; }
        public string HISO_Alt_EN { get; set; }
        public string HISO_Neu_DE { get; set; }
        public string HISO_Neu_FR { get; set; }
        public string HISO_Neu_IT { get; set; }
        public string HISO_Neu_EN { get; set; }
        public bool HISO_IsNew { get; set; }
        public bool HISO_IsChange { get; set; }
        public bool HISO_IsUpload { get; set; }
        public bool HISO_IsDownload { get; set; }
        public bool HISO_IsClient { get; set; }
        public int HISO_Version { get; set; }
        public bool HISO_IsGeloescht { get; set; }
        public int HISO_Status { get; set; }
        public string HISO_Filter1 { get; set; }
        public string HISO_Filter2 { get; set; }
        public bool HISO_IsAction { get; set; }
        public bool HISO_IsSubEntry { get; set; }
    
        public virtual T_AP_Standort T_AP_Standort { get; set; }
    }
}

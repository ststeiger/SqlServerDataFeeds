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
    
    public partial class T_AP_Kunst_History
    {
        public System.Guid HIKU_UID { get; set; }
        public System.Guid HIKU_KU_UID { get; set; }
        public System.Guid HIKU_Entry_UID { get; set; }
        public System.DateTime HIKU_Datum { get; set; }
        public string HIKU_User { get; set; }
        public string HIKU_Feld_DE { get; set; }
        public string HIKU_Feld_FR { get; set; }
        public string HIKU_Feld_IT { get; set; }
        public string HIKU_Feld_EN { get; set; }
        public string HIKU_Alt_DE { get; set; }
        public string HIKU_Alt_FR { get; set; }
        public string HIKU_Alt_IT { get; set; }
        public string HIKU_Alt_EN { get; set; }
        public string HIKU_Neu_DE { get; set; }
        public string HIKU_Neu_FR { get; set; }
        public string HIKU_Neu_IT { get; set; }
        public string HIKU_Neu_EN { get; set; }
        public bool HIKU_IsNew { get; set; }
        public bool HIKU_IsChange { get; set; }
        public bool HIKU_IsUpload { get; set; }
        public bool HIKU_IsDownload { get; set; }
        public bool HIKU_IsClient { get; set; }
        public int HIKU_Version { get; set; }
        public bool HIKU_IsGeloescht { get; set; }
        public int HIKU_Status { get; set; }
        public string HIKU_Filter1 { get; set; }
        public string HIKU_Filter2 { get; set; }
        public bool HIKU_IsAction { get; set; }
        public bool HIKU_IsSubEntry { get; set; }
    
        public virtual T_AP_Kunst T_AP_Kunst { get; set; }
    }
}

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
    
    public partial class T_AP_Trakt_History
    {
        public System.Guid HITK_UID { get; set; }
        public System.Guid HITK_TK_UID { get; set; }
        public System.Guid HITK_Entry_UID { get; set; }
        public System.DateTime HITK_Datum { get; set; }
        public string HITK_User { get; set; }
        public string HITK_Feld_DE { get; set; }
        public string HITK_Feld_FR { get; set; }
        public string HITK_Feld_IT { get; set; }
        public string HITK_Feld_EN { get; set; }
        public string HITK_Alt_DE { get; set; }
        public string HITK_Alt_FR { get; set; }
        public string HITK_Alt_IT { get; set; }
        public string HITK_Alt_EN { get; set; }
        public string HITK_Neu_DE { get; set; }
        public string HITK_Neu_FR { get; set; }
        public string HITK_Neu_IT { get; set; }
        public string HITK_Neu_EN { get; set; }
        public bool HITK_IsNew { get; set; }
        public bool HITK_IsChange { get; set; }
        public bool HITK_IsUpload { get; set; }
        public bool HITK_IsDownload { get; set; }
        public bool HITK_IsClient { get; set; }
        public int HITK_Version { get; set; }
        public bool HITK_IsGeloescht { get; set; }
        public int HITK_Status { get; set; }
        public string HITK_Filter1 { get; set; }
        public string HITK_Filter2 { get; set; }
        public bool HITK_IsAction { get; set; }
        public bool HITK_IsSubEntry { get; set; }
    
        public virtual T_AP_Trakt T_AP_Trakt { get; set; }
    }
}
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
    
    public partial class T_AP_Geschoss_History
    {
        public System.Guid HIGS_UID { get; set; }
        public System.Guid HIGS_GS_UID { get; set; }
        public System.Guid HIGS_Entry_UID { get; set; }
        public System.DateTime HIGS_Datum { get; set; }
        public string HIGS_User { get; set; }
        public string HIGS_Feld_DE { get; set; }
        public string HIGS_Feld_FR { get; set; }
        public string HIGS_Feld_IT { get; set; }
        public string HIGS_Feld_EN { get; set; }
        public string HIGS_Alt_DE { get; set; }
        public string HIGS_Alt_FR { get; set; }
        public string HIGS_Alt_IT { get; set; }
        public string HIGS_Alt_EN { get; set; }
        public string HIGS_Neu_DE { get; set; }
        public string HIGS_Neu_FR { get; set; }
        public string HIGS_Neu_IT { get; set; }
        public string HIGS_Neu_EN { get; set; }
        public bool HIGS_IsNew { get; set; }
        public bool HIGS_IsChange { get; set; }
        public bool HIGS_IsUpload { get; set; }
        public bool HIGS_IsDownload { get; set; }
        public bool HIGS_IsClient { get; set; }
        public int HIGS_Version { get; set; }
        public bool HIGS_IsGeloescht { get; set; }
        public int HIGS_Status { get; set; }
        public string HIGS_Filter1 { get; set; }
        public string HIGS_Filter2 { get; set; }
        public bool HIGS_IsAction { get; set; }
        public bool HIGS_IsSubEntry { get; set; }
    
        public virtual T_AP_Geschoss T_AP_Geschoss { get; set; }
    }
}

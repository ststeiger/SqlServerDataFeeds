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
    
    public partial class T_AP_Kontakte_History
    {
        public System.Guid HIKT_UID { get; set; }
        public System.Guid HIKT_KT_UID { get; set; }
        public System.Guid HIKT_Entry_UID { get; set; }
        public System.DateTime HIKT_Datum { get; set; }
        public string HIKT_User { get; set; }
        public string HIKT_Feld_DE { get; set; }
        public string HIKT_Feld_FR { get; set; }
        public string HIKT_Feld_IT { get; set; }
        public string HIKT_Feld_EN { get; set; }
        public string HIKT_Alt_DE { get; set; }
        public string HIKT_Alt_FR { get; set; }
        public string HIKT_Alt_IT { get; set; }
        public string HIKT_Alt_EN { get; set; }
        public string HIKT_Neu_DE { get; set; }
        public string HIKT_Neu_FR { get; set; }
        public string HIKT_Neu_IT { get; set; }
        public string HIKT_Neu_EN { get; set; }
        public bool HIKT_IsNew { get; set; }
        public bool HIKT_IsChange { get; set; }
        public bool HIKT_IsUpload { get; set; }
        public bool HIKT_IsDownload { get; set; }
        public bool HIKT_IsClient { get; set; }
        public int HIKT_Version { get; set; }
        public bool HIKT_IsGeloescht { get; set; }
        public int HIKT_Status { get; set; }
        public string HIKT_Filter1 { get; set; }
        public string HIKT_Filter2 { get; set; }
        public bool HIKT_IsAction { get; set; }
        public bool HIKT_IsSubEntry { get; set; }
    
        public virtual T_AP_Kontakte T_AP_Kontakte { get; set; }
    }
}

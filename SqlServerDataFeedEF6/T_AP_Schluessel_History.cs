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
    
    public partial class T_AP_Schluessel_History
    {
        public System.Guid HISL_UID { get; set; }
        public System.Guid HISL_SL_UID { get; set; }
        public System.Guid HISL_Entry_UID { get; set; }
        public System.DateTime HISL_Datum { get; set; }
        public string HISL_User { get; set; }
        public string HISL_Feld_DE { get; set; }
        public string HISL_Feld_FR { get; set; }
        public string HISL_Feld_IT { get; set; }
        public string HISL_Feld_EN { get; set; }
        public string HISL_Alt_DE { get; set; }
        public string HISL_Alt_FR { get; set; }
        public string HISL_Alt_IT { get; set; }
        public string HISL_Alt_EN { get; set; }
        public string HISL_Neu_DE { get; set; }
        public string HISL_Neu_FR { get; set; }
        public string HISL_Neu_IT { get; set; }
        public string HISL_Neu_EN { get; set; }
        public bool HISL_IsNew { get; set; }
        public bool HISL_IsChange { get; set; }
        public bool HISL_IsUpload { get; set; }
        public bool HISL_IsDownload { get; set; }
        public bool HISL_IsClient { get; set; }
        public int HISL_Version { get; set; }
        public bool HISL_IsGeloescht { get; set; }
        public int HISL_Status { get; set; }
        public string HISL_Filter1 { get; set; }
        public string HISL_Filter2 { get; set; }
        public bool HISL_IsAction { get; set; }
        public bool HISL_IsSubEntry { get; set; }
    
        public virtual T_AP_Schluessel T_AP_Schluessel { get; set; }
    }
}

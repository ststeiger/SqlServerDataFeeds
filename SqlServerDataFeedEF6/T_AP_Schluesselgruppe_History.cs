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
    
    public partial class T_AP_Schluesselgruppe_History
    {
        public System.Guid HISLG_UID { get; set; }
        public System.Guid HISLG_SLG_UID { get; set; }
        public Nullable<System.Guid> HISLG_Entry_UID { get; set; }
        public System.DateTime HISLG_Datum { get; set; }
        public string HISLG_User { get; set; }
        public string HISLG_Feld_DE { get; set; }
        public string HISLG_Feld_FR { get; set; }
        public string HISLG_Feld_IT { get; set; }
        public string HISLG_Feld_EN { get; set; }
        public string HISLG_Alt_DE { get; set; }
        public string HISLG_Alt_FR { get; set; }
        public string HISLG_Alt_IT { get; set; }
        public string HISLG_Alt_EN { get; set; }
        public string HISLG_Neu_DE { get; set; }
        public string HISLG_Neu_FR { get; set; }
        public string HISLG_Neu_IT { get; set; }
        public string HISLG_Neu_EN { get; set; }
        public bool HISLG_IsNew { get; set; }
        public bool HISLG_IsChange { get; set; }
        public bool HISLG_IsUpload { get; set; }
        public bool HISLG_IsDownload { get; set; }
        public bool HISLG_IsClient { get; set; }
        public int HISLG_Version { get; set; }
        public bool HISLG_IsAction { get; set; }
        public bool HISLG_IsAddRow { get; set; }
        public bool HISLG_IsSubEntry { get; set; }
        public string HISLG_Filter1 { get; set; }
        public string HISLG_Filter2 { get; set; }
        public int HISLG_Status { get; set; }
    
        public virtual T_AP_Schluesselgruppe T_AP_Schluesselgruppe { get; set; }
    }
}

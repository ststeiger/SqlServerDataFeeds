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
    
    public partial class T_AP_Mobiliar_History
    {
        public System.Guid HIMO_UID { get; set; }
        public System.Guid HIMO_MO_UID { get; set; }
        public System.Guid HIMO_Entry_UID { get; set; }
        public System.DateTime HIMO_Datum { get; set; }
        public string HIMO_User { get; set; }
        public string HIMO_Feld_DE { get; set; }
        public string HIMO_Feld_FR { get; set; }
        public string HIMO_Feld_IT { get; set; }
        public string HIMO_Feld_EN { get; set; }
        public string HIMO_Alt_DE { get; set; }
        public string HIMO_Alt_FR { get; set; }
        public string HIMO_Alt_IT { get; set; }
        public string HIMO_Alt_EN { get; set; }
        public string HIMO_Neu_DE { get; set; }
        public string HIMO_Neu_FR { get; set; }
        public string HIMO_Neu_IT { get; set; }
        public string HIMO_Neu_EN { get; set; }
        public bool HIMO_IsNew { get; set; }
        public bool HIMO_IsChange { get; set; }
        public bool HIMO_IsUpload { get; set; }
        public bool HIMO_IsDownload { get; set; }
        public bool HIMO_IsClient { get; set; }
        public int HIMO_Version { get; set; }
        public bool HIMO_IsGeloescht { get; set; }
        public int HIMO_Status { get; set; }
        public string HIMO_Filter1 { get; set; }
        public string HIMO_Filter2 { get; set; }
        public bool HIMO_IsAction { get; set; }
        public bool HIMO_IsSubEntry { get; set; }
    
        public virtual T_AP_Mobiliar T_AP_Mobiliar { get; set; }
    }
}

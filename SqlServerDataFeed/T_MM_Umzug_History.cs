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
    
    public partial class T_MM_Umzug_History
    {
        public System.Guid HIMMU_UID { get; set; }
        public Nullable<System.Guid> HIMMU_Entry_UID { get; set; }
        public System.DateTime HIMMU_Datum { get; set; }
        public string HIMMU_User { get; set; }
        public string HIMMU_Feld_DE { get; set; }
        public string HIMMU_Feld_FR { get; set; }
        public string HIMMU_Feld_IT { get; set; }
        public string HIMMU_Feld_EN { get; set; }
        public string HIMMU_Alt_DE { get; set; }
        public string HIMMU_Alt_FR { get; set; }
        public string HIMMU_Alt_IT { get; set; }
        public string HIMMU_Alt_EN { get; set; }
        public string HIMMU_Neu_DE { get; set; }
        public string HIMMU_Neu_FR { get; set; }
        public string HIMMU_Neu_IT { get; set; }
        public string HIMMU_Neu_EN { get; set; }
        public bool HIMMU_IsNew { get; set; }
        public bool HIMMU_IsChange { get; set; }
        public bool HIMMU_IsUpload { get; set; }
        public bool HIMMU_IsDownload { get; set; }
        public bool HIMMU_IsClient { get; set; }
        public int HIMMU_Version { get; set; }
        public bool HIMMU_IsAction { get; set; }
        public bool HIMMU_IsAddRow { get; set; }
        public bool HIMMU_IsSubEntry { get; set; }
        public string HIMMU_Filter1 { get; set; }
        public string HIMMU_Filter2 { get; set; }
        public int HIMMU_Status { get; set; }
    
        public virtual T_MM_Umzug T_MM_Umzug { get; set; }
    }
}

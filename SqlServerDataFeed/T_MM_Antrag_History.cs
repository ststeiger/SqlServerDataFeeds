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
    
    public partial class T_MM_Antrag_History
    {
        public System.Guid HIMMA_UID { get; set; }
        public System.Guid HIMMA_MMA_UID { get; set; }
        public Nullable<System.Guid> HIMMA_Entry_UID { get; set; }
        public System.DateTime HIMMA_Datum { get; set; }
        public string HIMMA_User { get; set; }
        public string HIMMA_Feld_DE { get; set; }
        public string HIMMA_Feld_FR { get; set; }
        public string HIMMA_Feld_IT { get; set; }
        public string HIMMA_Feld_EN { get; set; }
        public string HIMMA_Alt_DE { get; set; }
        public string HIMMA_Alt_FR { get; set; }
        public string HIMMA_Alt_IT { get; set; }
        public string HIMMA_Alt_EN { get; set; }
        public string HIMMA_Neu_DE { get; set; }
        public string HIMMA_Neu_FR { get; set; }
        public string HIMMA_Neu_IT { get; set; }
        public string HIMMA_Neu_EN { get; set; }
        public bool HIMMA_IsNew { get; set; }
        public bool HIMMA_IsChange { get; set; }
        public bool HIMMA_IsUpload { get; set; }
        public bool HIMMA_IsDownload { get; set; }
        public bool HIMMA_IsClient { get; set; }
        public int HIMMA_Version { get; set; }
        public bool HIMMA_IsAction { get; set; }
        public bool HIMMA_IsAddRow { get; set; }
        public string HIMMA_Filter1 { get; set; }
        public string HIMMA_Filter2 { get; set; }
        public bool HIMMA_IsSubEntry { get; set; }
        public int HIMMA_Status { get; set; }
    
        public virtual T_MM_Antrag T_MM_Antrag { get; set; }
    }
}

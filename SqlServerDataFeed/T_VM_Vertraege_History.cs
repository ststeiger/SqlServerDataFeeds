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
    
    public partial class T_VM_Vertraege_History
    {
        public System.Guid HIVTR_UID { get; set; }
        public System.Guid HIVTR_VTR_UID { get; set; }
        public System.Guid HIVTR_Entry_UID { get; set; }
        public System.DateTime HIVTR_Datum { get; set; }
        public string HIVTR_User { get; set; }
        public string HIVTR_Feld_DE { get; set; }
        public string HIVTR_Feld_FR { get; set; }
        public string HIVTR_Feld_IT { get; set; }
        public string HIVTR_Feld_EN { get; set; }
        public string HIVTR_Alt_DE { get; set; }
        public string HIVTR_Alt_FR { get; set; }
        public string HIVTR_Alt_IT { get; set; }
        public string HIVTR_Alt_EN { get; set; }
        public string HIVTR_Neu_DE { get; set; }
        public string HIVTR_Neu_FR { get; set; }
        public string HIVTR_Neu_IT { get; set; }
        public string HIVTR_Neu_EN { get; set; }
        public bool HIVTR_IsNew { get; set; }
        public bool HIVTR_IsChange { get; set; }
        public bool HIVTR_IsUpload { get; set; }
        public bool HIVTR_IsDownload { get; set; }
        public bool HIVTR_IsClient { get; set; }
        public int HIVTR_Version { get; set; }
        public bool HIVTR_IsGeloescht { get; set; }
        public int HIVTR_Status { get; set; }
        public string HIVTR_Filter1 { get; set; }
        public string HIVTR_Filter2 { get; set; }
        public bool HIVTR_IsAction { get; set; }
        public bool HIVTR_IsSubEntry { get; set; }
    
        public virtual T_VM_Vertraege T_VM_Vertraege { get; set; }
    }
}

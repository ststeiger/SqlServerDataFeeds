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
    
    public partial class T_DMS_Folder_History
    {
        public System.Guid HIFO_UID { get; set; }
        public System.Guid HIFO_FO_UID { get; set; }
        public System.DateTime HIFO_Datum { get; set; }
        public string HIFO_User { get; set; }
        public string HIFO_Text_DE { get; set; }
        public string HIFO_Text_FR { get; set; }
        public string HIFO_Text_IT { get; set; }
        public string HIFO_Text_EN { get; set; }
        public bool HIFO_IsNew { get; set; }
        public bool HIFO_IsChange { get; set; }
        public int HIFO_Status { get; set; }
    
        public virtual T_DMS_Folder T_DMS_Folder { get; set; }
    }
}

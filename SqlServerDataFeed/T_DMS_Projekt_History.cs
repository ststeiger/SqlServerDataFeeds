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
    
    public partial class T_DMS_Projekt_History
    {
        public System.Guid HIPJ_UID { get; set; }
        public System.DateTime HIPJ_Datum { get; set; }
        public string HIPJ_User { get; set; }
        public string HIPJ_Text_DE { get; set; }
        public string HIPJ_Text_FR { get; set; }
        public string HIPJ_Text_IT { get; set; }
        public string HIPJ_Text_EN { get; set; }
        public bool HIPJ_IsNew { get; set; }
        public bool HIPJ_IsChange { get; set; }
        public int HIPJ_Status { get; set; }
    
        public virtual T_DMS_Projekt T_DMS_Projekt { get; set; }
    }
}

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
    
    public partial class T_DMS_Navigation
    {
        public System.Guid NAV_UID { get; set; }
        public Nullable<int> NAV_Typ { get; set; }
        public Nullable<System.Guid> NAV_Parent_UID { get; set; }
        public int NAV_Stufe { get; set; }
        public string NAV_ApertureKey { get; set; }
        public string NAV_Nr { get; set; }
        public string NAV_Bemerkung { get; set; }
        public int NAV_Status { get; set; }
        public Nullable<byte> NAV_Referenz { get; set; }
    
        public virtual T_DMS_Dokument T_DMS_Dokument { get; set; }
        public virtual T_DMS_Folder T_DMS_Folder { get; set; }
        public virtual T_DMS_Projekt T_DMS_Projekt { get; set; }
    }
}

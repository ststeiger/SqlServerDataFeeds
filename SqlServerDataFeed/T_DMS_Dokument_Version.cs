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
    
    public partial class T_DMS_Dokument_Version
    {
        public System.Guid DV_UID { get; set; }
        public string DV_Datei { get; set; }
        public int DV_Version { get; set; }
        public Nullable<System.DateTime> DV_VersionDatum { get; set; }
        public System.DateTime DV_Datum { get; set; }
        public string DV_UploadUser { get; set; }
        public bool DV_IsGesperrt { get; set; }
        public string DV_OriginalDateiname { get; set; }
        public int DV_Status { get; set; }
    
        public virtual T_DMS_Dokument T_DMS_Dokument { get; set; }
    }
}

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
    
    public partial class T_ZO_AP_Raum_DWG
    {
        public System.Guid ZO_RMDWG_UID { get; set; }
        public System.Guid ZO_RMDWG_RM_UID { get; set; }
        public string ZO_RMDWG_ApertureDWG { get; set; }
        public System.DateTime ZO_RMDWG_DatumVon { get; set; }
        public System.DateTime ZO_RMDWG_DatumBis { get; set; }
        public string ZO_RMDWG_ApertureObjID { get; set; }
        public int ZO_RMDWG_Status { get; set; }
        public string ZO_RMDWG_DWGID { get; set; }
    
        public virtual T_AP_Raum T_AP_Raum { get; set; }
    }
}

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
    
    public partial class T_ZO_AP_Ref_AnlageKategorie_AP_Ref_AnlageKategorieSchema
    {
        public System.Guid ZO_AKAKS_UID { get; set; }
        public int ZO_AKAKS_Status { get; set; }
    
        public virtual T_AP_Ref_AnlageKategorie T_AP_Ref_AnlageKategorie { get; set; }
        public virtual T_AP_Ref_AnlageKategorieSchema T_AP_Ref_AnlageKategorieSchema { get; set; }
    }
}

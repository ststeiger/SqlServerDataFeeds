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
    
    public partial class T_ZO_AP_Grundstueck_Flaeche
    {
        public System.Guid ZO_GRUFlaeche_UID { get; set; }
        public System.Guid ZO_GRUFlaeche_GRU_UID { get; set; }
        public Nullable<double> ZO_GRUFlaeche_Flaeche { get; set; }
        public System.DateTime ZO_GRUFlaeche_DatumVon { get; set; }
        public System.DateTime ZO_GRUFlaeche_DatumBis { get; set; }
        public int ZO_GRUFlaeche_Status { get; set; }
    
        public virtual T_AP_Grundstueck T_AP_Grundstueck { get; set; }
    }
}

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
    
    public partial class T_ZO_AP_Parkplatz_Flaeche
    {
        public System.Guid ZO_PPFlaeche_UID { get; set; }
        public Nullable<double> ZO_PPFlaeche_Flaeche { get; set; }
        public System.DateTime ZO_PPFlaeche_DatumVon { get; set; }
        public System.DateTime ZO_PPFlaeche_DatumBis { get; set; }
        public int ZO_PPFlaeche_Status { get; set; }
    
        public virtual T_AP_Parkplatz T_AP_Parkplatz { get; set; }
    }
}

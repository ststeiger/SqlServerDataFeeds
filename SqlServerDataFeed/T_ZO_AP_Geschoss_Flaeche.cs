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
    
    public partial class T_ZO_AP_Geschoss_Flaeche
    {
        public System.Guid ZO_GSFlaeche_UID { get; set; }
        public Nullable<double> ZO_GSFlaeche_Flaeche { get; set; }
        public System.DateTime ZO_GSFlaeche_DatumVon { get; set; }
        public System.DateTime ZO_GSFlaeche_DatumBis { get; set; }
        public int ZO_GSFlaeche_Status { get; set; }
    
        public virtual T_AP_Geschoss T_AP_Geschoss { get; set; }
    }
}

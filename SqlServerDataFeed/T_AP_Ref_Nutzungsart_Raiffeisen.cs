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
    
    public partial class T_AP_Ref_Nutzungsart_Raiffeisen
    {
        public System.Guid NA_UID { get; set; }
        public System.Guid NA_NA_UID { get; set; }
        public Nullable<double> NA_AP_Faktor { get; set; }
        public Nullable<double> NA_Gewichtung_Faktor { get; set; }
        public int NA_Status { get; set; }
    
        public virtual T_AP_Ref_Nutzungsart T_AP_Ref_Nutzungsart { get; set; }
    }
}

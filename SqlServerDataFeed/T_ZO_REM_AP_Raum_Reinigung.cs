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
    
    public partial class T_ZO_REM_AP_Raum_Reinigung
    {
        public System.Guid ZO_RMREM_UID { get; set; }
        public double ZO_RMREM_REMAL_Eingabe { get; set; }
        public System.DateTime ZO_RMREM_GueltigVon { get; set; }
        public System.DateTime ZO_RMREM_GueltigBis { get; set; }
        public int ZO_RMREM_Status { get; set; }
        public Nullable<bool> ZO_RMREM_Mo { get; set; }
        public Nullable<bool> ZO_RMREM_Di { get; set; }
        public Nullable<bool> ZO_RMREM_Mi { get; set; }
        public Nullable<bool> ZO_RMREM_Do { get; set; }
        public Nullable<bool> ZO_RMREM_Fr { get; set; }
        public Nullable<bool> ZO_RMREM_Sa { get; set; }
        public Nullable<bool> ZO_RMREM_So { get; set; }
    
        public virtual T_AP_Raum T_AP_Raum { get; set; }
        public virtual T_REM_Ref_AnzahlTag T_REM_Ref_AnzahlTag { get; set; }
        public virtual T_REM_Ref_Arbeitsgang T_REM_Ref_Arbeitsgang { get; set; }
        public virtual T_REM_Ref_Arbeitsgang_Leistung T_REM_Ref_Arbeitsgang_Leistung { get; set; }
        public virtual T_REM_Ref_Intervall T_REM_Ref_Intervall { get; set; }
    }
}

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
    
    public partial class T_VAR_Variante
    {
        public T_VAR_Variante()
        {
            this.T_AP_Anlage = new HashSet<T_AP_Anlage>();
            this.T_AP_Parkplatz = new HashSet<T_AP_Parkplatz>();
            this.T_AP_Raum = new HashSet<T_AP_Raum>();
            this.T_AP_Zone = new HashSet<T_AP_Zone>();
        }
    
        public System.Guid VAR_UID { get; set; }
        public System.Guid VAR_PRJ_UID { get; set; }
        public string VAR_Nr { get; set; }
        public string VAR_Bezeichnung { get; set; }
        public string VAR_Bemerkung { get; set; }
        public int VAR_Status { get; set; }
        public Nullable<System.DateTime> VAR_MutDate { get; set; }
        public string VAR_MutUser { get; set; }
    
        public virtual ICollection<T_AP_Anlage> T_AP_Anlage { get; set; }
        public virtual ICollection<T_AP_Parkplatz> T_AP_Parkplatz { get; set; }
        public virtual ICollection<T_AP_Raum> T_AP_Raum { get; set; }
        public virtual ICollection<T_AP_Zone> T_AP_Zone { get; set; }
        public virtual T_VAR_Projekt T_VAR_Projekt { get; set; }
    }
}

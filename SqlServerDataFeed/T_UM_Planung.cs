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
    
    public partial class T_UM_Planung
    {
        public T_UM_Planung()
        {
            this.T_UM_Umzug = new HashSet<T_UM_Umzug>();
        }
    
        public System.Guid UMP_UID { get; set; }
        public int UMP_AntragID { get; set; }
        public string UMP_Beschreibung { get; set; }
        public int UMP_Status { get; set; }
        public Nullable<System.DateTime> UMP_Datum_Erstellung { get; set; }
        public Nullable<System.DateTime> UMP_Datum_Aenderung { get; set; }
        public Nullable<System.DateTime> UMP_Datum_Eingereicht { get; set; }
        public bool UMP_IsMove { get; set; }
    
        public virtual T_AP_Kontakte T_AP_Kontakte { get; set; }
        public virtual T_AP_Kontakte T_AP_Kontakte1 { get; set; }
        public virtual T_AP_Ref_Kostenstelle T_AP_Ref_Kostenstelle { get; set; }
        public virtual T_UM_Ref_Status T_UM_Ref_Status { get; set; }
        public virtual ICollection<T_UM_Umzug> T_UM_Umzug { get; set; }
    }
}

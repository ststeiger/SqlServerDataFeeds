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
    
    public partial class T_AP_Schluessel
    {
        public T_AP_Schluessel()
        {
            this.T_AP_Schluessel_History = new HashSet<T_AP_Schluessel_History>();
            this.T_AP_Schluessel_Protokoll = new HashSet<T_AP_Schluessel_Protokoll>();
            this.T_AP_Schluessel1 = new HashSet<T_AP_Schluessel>();
            this.T_ZO_AP_Schluessel_AP_Kontakte = new HashSet<T_ZO_AP_Schluessel_AP_Kontakte>();
        }
    
        public System.Guid SL_UID { get; set; }
        public System.DateTime SL_DatumVon { get; set; }
        public Nullable<System.DateTime> SL_DatumBis { get; set; }
        public Nullable<System.DateTime> SL_DatumAktion { get; set; }
        public string SL_Nr { get; set; }
        public string SL_Bemerkung { get; set; }
        public int SL_Status { get; set; }
        public bool SL_IsNachbestellung { get; set; }
        public Nullable<System.Guid> SL_SA_UID { get; set; }
        public string SL_HakenNr { get; set; }
    
        public virtual T_AP_Kontakte T_AP_Kontakte { get; set; }
        public virtual T_AP_Mobiliar T_AP_Mobiliar { get; set; }
        public virtual T_AP_Ref_SchluesselStatus T_AP_Ref_SchluesselStatus { get; set; }
        public virtual ICollection<T_AP_Schluessel_History> T_AP_Schluessel_History { get; set; }
        public virtual ICollection<T_AP_Schluessel_Protokoll> T_AP_Schluessel_Protokoll { get; set; }
        public virtual ICollection<T_AP_Schluessel> T_AP_Schluessel1 { get; set; }
        public virtual T_AP_Schluessel T_AP_Schluessel2 { get; set; }
        public virtual T_AP_Schluesselgruppe T_AP_Schluesselgruppe { get; set; }
        public virtual T_AV_Adressen T_AV_Adressen { get; set; }
        public virtual ICollection<T_ZO_AP_Schluessel_AP_Kontakte> T_ZO_AP_Schluessel_AP_Kontakte { get; set; }
    }
}

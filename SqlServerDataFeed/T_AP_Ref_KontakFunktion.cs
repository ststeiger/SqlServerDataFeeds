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
    
    public partial class T_AP_Ref_KontakFunktion
    {
        public T_AP_Ref_KontakFunktion()
        {
            this.T_ZO_AP_Kontakte_AP_Ref_Funktionen = new HashSet<T_ZO_AP_Kontakte_AP_Ref_Funktionen>();
            this.T_ZO_AP_Objekt_AP_Kontakte = new HashSet<T_ZO_AP_Objekt_AP_Kontakte>();
            this.T_ZO_AP_Schluesselgruppe_AP_Ref_Funktionen = new HashSet<T_ZO_AP_Schluesselgruppe_AP_Ref_Funktionen>();
        }
    
        public System.Guid KF_UID { get; set; }
        public int KF_MDT_ID { get; set; }
        public Nullable<int> KF_Code { get; set; }
        public string KF_Kurz_DE { get; set; }
        public string KF_Kurz_FR { get; set; }
        public string KF_Kurz_IT { get; set; }
        public string KF_Kurz_EN { get; set; }
        public string KF_Lang_DE { get; set; }
        public string KF_Lang_FR { get; set; }
        public string KF_Lang_IT { get; set; }
        public string KF_Lang_EN { get; set; }
        public int KF_Status { get; set; }
        public int KF_Sort { get; set; }
        public Nullable<int> KF_StylizerFore { get; set; }
        public Nullable<int> KF_StylizerBack { get; set; }
        public Nullable<int> KF_StylizerPattern { get; set; }
        public Nullable<int> KF_StylizerLine { get; set; }
        public bool KF_IsDefault { get; set; }
        public Nullable<System.DateTime> KF_DatumMut { get; set; }
        public string KF_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual ICollection<T_ZO_AP_Kontakte_AP_Ref_Funktionen> T_ZO_AP_Kontakte_AP_Ref_Funktionen { get; set; }
        public virtual ICollection<T_ZO_AP_Objekt_AP_Kontakte> T_ZO_AP_Objekt_AP_Kontakte { get; set; }
        public virtual ICollection<T_ZO_AP_Schluesselgruppe_AP_Ref_Funktionen> T_ZO_AP_Schluesselgruppe_AP_Ref_Funktionen { get; set; }
    }
}

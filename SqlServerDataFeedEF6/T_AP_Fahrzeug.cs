//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SqlServerDataFeedEF6
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_AP_Fahrzeug
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Fahrzeug()
        {
            this.T_TM_Tasks_Planung = new HashSet<T_TM_Tasks_Planung>();
        }
    
        public System.Guid FZ_UID { get; set; }
        public int FZ_MDT_ID { get; set; }
        public string FZ_ApertureKey { get; set; }
        public Nullable<System.Guid> FZ_SO_UID { get; set; }
        public Nullable<System.Guid> FZ_GB_UID { get; set; }
        public Nullable<System.Guid> FZ_GS_UID { get; set; }
        public Nullable<System.Guid> FZ_RM_UID { get; set; }
        public Nullable<System.Guid> FZ_PP_UID { get; set; }
        public string FZ_Nr { get; set; }
        public string FZ_Modell { get; set; }
        public string FZ_GestellNr { get; set; }
        public Nullable<double> FZ_Kilometerstand { get; set; }
        public Nullable<double> FZ_Betriebsstunden { get; set; }
        public Nullable<double> FZ_Leistung { get; set; }
        public Nullable<double> FZ_Hubraum { get; set; }
        public string FZ_Farbnummer { get; set; }
        public Nullable<System.DateTime> FZ_Erstzulassung { get; set; }
        public Nullable<System.DateTime> FZ_LetztePruefung { get; set; }
        public Nullable<System.DateTime> FZ_Kaufdatum { get; set; }
        public Nullable<double> FZ_Kaufpreis { get; set; }
        public string FZ_Bezugsquelle { get; set; }
        public string FZ_Besitzer { get; set; }
        public string FZ_Bemerkung { get; set; }
        public Nullable<System.DateTime> FZ_DatumVon { get; set; }
        public Nullable<System.DateTime> FZ_DatumBis { get; set; }
        public Nullable<int> FZ_Status { get; set; }
        public Nullable<System.DateTime> FZ_MutDate { get; set; }
        public string FZ_MutUser { get; set; }
        public Nullable<System.Guid> FZ_FZTYP_UID { get; set; }
        public Nullable<System.Guid> FZ_FZHE_UID { get; set; }
    
        public virtual T_AP_Gebaeude T_AP_Gebaeude { get; set; }
        public virtual T_AP_Geschoss T_AP_Geschoss { get; set; }
        public virtual T_AP_Parkplatz T_AP_Parkplatz { get; set; }
        public virtual T_AP_Raum T_AP_Raum { get; set; }
        public virtual T_AP_Ref_FahrzeugHersteller T_AP_Ref_FahrzeugHersteller { get; set; }
        public virtual T_AP_Ref_FahrzeugTyp T_AP_Ref_FahrzeugTyp { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_AP_Standort T_AP_Standort { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TM_Tasks_Planung> T_TM_Tasks_Planung { get; set; }
    }
}

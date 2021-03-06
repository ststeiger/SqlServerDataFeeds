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
    
    public partial class T_AP_Kommunikation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Kommunikation()
        {
            this.T_AP_Kommunikation_History = new HashSet<T_AP_Kommunikation_History>();
            this.T_SYS_Kommunikationrechte = new HashSet<T_SYS_Kommunikationrechte>();
            this.T_TM_Tasks_Planung = new HashSet<T_TM_Tasks_Planung>();
            this.T_TM_Tasks = new HashSet<T_TM_Tasks>();
            this.T_ZO_AP_Kommunikation_DWG = new HashSet<T_ZO_AP_Kommunikation_DWG>();
        }
    
        public System.Guid KM_UID { get; set; }
        public string KM_ApertureKey { get; set; }
        public int KM_MDT_ID { get; set; }
        public Nullable<System.Guid> KM_RM_UID { get; set; }
        public Nullable<System.Guid> KM_KMKAT_UID { get; set; }
        public Nullable<System.Guid> KM_KMA_UID { get; set; }
        public Nullable<System.Guid> KM_ADR_UID { get; set; }
        public Nullable<System.Guid> KM_KST_UID { get; set; }
        public string KM_Nr { get; set; }
        public string KM_Hersteller { get; set; }
        public string KM_Modell { get; set; }
        public string KM_Typ { get; set; }
        public string KM_TypenNr { get; set; }
        public string KM_SerienNr { get; set; }
        public string KM_Rufnummer { get; set; }
        public Nullable<System.DateTime> KM_Inbetriebnahme { get; set; }
        public string KM_Bezeichnung { get; set; }
        public string KM_Bemerkung { get; set; }
        public System.DateTime KM_DatumVon { get; set; }
        public System.DateTime KM_DatumBis { get; set; }
        public int KM_Status { get; set; }
        public Nullable<System.Guid> KM_AP_UID { get; set; }
    
        public virtual T_AP_Arbeitsplatz T_AP_Arbeitsplatz { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Kommunikation_History> T_AP_Kommunikation_History { get; set; }
        public virtual T_AP_Raum T_AP_Raum { get; set; }
        public virtual T_AP_Ref_KommunikationAnbieter T_AP_Ref_KommunikationAnbieter { get; set; }
        public virtual T_AP_Ref_KommunikationKategorie T_AP_Ref_KommunikationKategorie { get; set; }
        public virtual T_AP_Ref_Kostenstelle T_AP_Ref_Kostenstelle { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_AV_Adressen T_AV_Adressen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_SYS_Kommunikationrechte> T_SYS_Kommunikationrechte { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TM_Tasks_Planung> T_TM_Tasks_Planung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TM_Tasks> T_TM_Tasks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Kommunikation_DWG> T_ZO_AP_Kommunikation_DWG { get; set; }
    }
}

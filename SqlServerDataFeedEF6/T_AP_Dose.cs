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
    
    public partial class T_AP_Dose
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Dose()
        {
            this.T_AP_Anschluss = new HashSet<T_AP_Anschluss>();
            this.T_AP_Dose_History = new HashSet<T_AP_Dose_History>();
            this.T_SYS_Doserechte = new HashSet<T_SYS_Doserechte>();
            this.T_TM_Tasks_Planung = new HashSet<T_TM_Tasks_Planung>();
            this.T_TM_Tasks = new HashSet<T_TM_Tasks>();
            this.T_ZO_AP_Dose_DWG = new HashSet<T_ZO_AP_Dose_DWG>();
        }
    
        public System.Guid DO_UID { get; set; }
        public int DO_MDT_ID { get; set; }
        public Nullable<System.Guid> DO_RM_UID { get; set; }
        public Nullable<System.Guid> DO_DKAT_UID { get; set; }
        public string DO_ApertureKey { get; set; }
        public string DO_Nr { get; set; }
        public string DO_Bezeichnung { get; set; }
        public string DO_Bemerkung { get; set; }
        public System.DateTime DO_DatumVon { get; set; }
        public System.DateTime DO_DatumBis { get; set; }
        public int DO_Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Anschluss> T_AP_Anschluss { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Dose_History> T_AP_Dose_History { get; set; }
        public virtual T_AP_Raum T_AP_Raum { get; set; }
        public virtual T_AP_Ref_DoseKategorie T_AP_Ref_DoseKategorie { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_SYS_Doserechte> T_SYS_Doserechte { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TM_Tasks_Planung> T_TM_Tasks_Planung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TM_Tasks> T_TM_Tasks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Dose_DWG> T_ZO_AP_Dose_DWG { get; set; }
    }
}

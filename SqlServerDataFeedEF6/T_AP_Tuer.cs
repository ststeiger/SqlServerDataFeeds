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
    
    public partial class T_AP_Tuer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Tuer()
        {
            this.T_AP_Tuer_History = new HashSet<T_AP_Tuer_History>();
            this.T_AP_Zylinder = new HashSet<T_AP_Zylinder>();
            this.T_SYS_Tuerrechte = new HashSet<T_SYS_Tuerrechte>();
            this.T_TM_Tasks_Planung = new HashSet<T_TM_Tasks_Planung>();
            this.T_TM_Tasks = new HashSet<T_TM_Tasks>();
            this.T_ZO_AP_Tuer_Schliessung = new HashSet<T_ZO_AP_Tuer_Schliessung>();
            this.T_ZO_AP_Tuer_DWG = new HashSet<T_ZO_AP_Tuer_DWG>();
        }
    
        public System.Guid TR_UID { get; set; }
        public int TR_MDT_ID { get; set; }
        public string TR_ApertureKey { get; set; }
        public Nullable<System.Guid> TR_RM_UID { get; set; }
        public Nullable<System.Guid> TR_TF_UID { get; set; }
        public Nullable<System.Guid> TR_TM_UID { get; set; }
        public Nullable<System.Guid> TR_TBS_UID { get; set; }
        public Nullable<System.Guid> TR_TT_UID { get; set; }
        public string TR_Nr { get; set; }
        public double TR_Glasanteil { get; set; }
        public double TR_Breite { get; set; }
        public double TR_Hoehe { get; set; }
        public bool TR_IsUeberwacht { get; set; }
        public bool TR_IsBrandfallgesteuert { get; set; }
        public string TR_Bezeichnung { get; set; }
        public string TR_Bemerkung { get; set; }
        public System.DateTime TR_DatumVon { get; set; }
        public System.DateTime TR_DatumBis { get; set; }
        public int TR_Status { get; set; }
    
        public virtual T_AP_Raum T_AP_Raum { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_AP_Ref_TuerBrandschutz T_AP_Ref_TuerBrandschutz { get; set; }
        public virtual T_AP_Ref_TuerFunktion T_AP_Ref_TuerFunktion { get; set; }
        public virtual T_AP_Ref_TuerMaterial T_AP_Ref_TuerMaterial { get; set; }
        public virtual T_AP_Ref_TuerTyp T_AP_Ref_TuerTyp { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Tuer_History> T_AP_Tuer_History { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Zylinder> T_AP_Zylinder { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_SYS_Tuerrechte> T_SYS_Tuerrechte { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TM_Tasks_Planung> T_TM_Tasks_Planung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TM_Tasks> T_TM_Tasks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Tuer_Schliessung> T_ZO_AP_Tuer_Schliessung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Tuer_DWG> T_ZO_AP_Tuer_DWG { get; set; }
    }
}

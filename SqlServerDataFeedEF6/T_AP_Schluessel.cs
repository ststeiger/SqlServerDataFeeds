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
    
    public partial class T_AP_Schluessel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Schluessel()
        {
            this.T_AP_Schluessel_History = new HashSet<T_AP_Schluessel_History>();
            this.T_AP_Schluessel_Protokoll = new HashSet<T_AP_Schluessel_Protokoll>();
            this.T_AP_Schluessel1 = new HashSet<T_AP_Schluessel>();
            this.T_ZO_AP_Schluessel_AP_Kontakte = new HashSet<T_ZO_AP_Schluessel_AP_Kontakte>();
        }
    
        public System.Guid SL_UID { get; set; }
        public Nullable<System.Guid> SL_SLG_UID { get; set; }
        public Nullable<System.Guid> SL_KT_UID { get; set; }
        public Nullable<System.Guid> SL_SLS_UID { get; set; }
        public System.DateTime SL_DatumVon { get; set; }
        public Nullable<System.DateTime> SL_DatumBis { get; set; }
        public Nullable<System.DateTime> SL_DatumAktion { get; set; }
        public string SL_Nr { get; set; }
        public string SL_Bemerkung { get; set; }
        public int SL_Status { get; set; }
        public bool SL_IsNachbestellung { get; set; }
        public Nullable<System.Guid> SL_SA_UID { get; set; }
        public Nullable<System.Guid> SL_MO_UID { get; set; }
        public Nullable<System.Guid> SL_ADR_UID { get; set; }
        public Nullable<System.Guid> SL_SL_UID { get; set; }
    
        public virtual T_AP_Kontakte T_AP_Kontakte { get; set; }
        public virtual T_AP_Mobiliar T_AP_Mobiliar { get; set; }
        public virtual T_AP_Ref_SchluesselStatus T_AP_Ref_SchluesselStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Schluessel_History> T_AP_Schluessel_History { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Schluessel_Protokoll> T_AP_Schluessel_Protokoll { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Schluessel> T_AP_Schluessel1 { get; set; }
        public virtual T_AP_Schluessel T_AP_Schluessel2 { get; set; }
        public virtual T_AP_Schluesselgruppe T_AP_Schluesselgruppe { get; set; }
        public virtual T_AV_Adressen T_AV_Adressen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Schluessel_AP_Kontakte> T_ZO_AP_Schluessel_AP_Kontakte { get; set; }
    }
}

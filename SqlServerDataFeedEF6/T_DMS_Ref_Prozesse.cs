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
    
    public partial class T_DMS_Ref_Prozesse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_DMS_Ref_Prozesse()
        {
            this.T_DMS_ZO_Prozesse_Berechtigungen = new HashSet<T_DMS_ZO_Prozesse_Berechtigungen>();
        }
    
        public System.Guid PROC_UID { get; set; }
        public Nullable<int> PROC_MDT_ID { get; set; }
        public Nullable<int> PROC_Code { get; set; }
        public string PROC_Kurz_DE { get; set; }
        public string PROC_Kurz_FR { get; set; }
        public string PROC_Kurz_IT { get; set; }
        public string PROC_Kurz_EN { get; set; }
        public string PROC_Lang_DE { get; set; }
        public string PROC_Lang_FR { get; set; }
        public string PROC_Lang_IT { get; set; }
        public string PROC_Lang_EN { get; set; }
        public bool PROC_HasDate { get; set; }
        public bool PROC_HasVerantwortlicher { get; set; }
        public string PROC_FieldVerantwortlich { get; set; }
        public bool PROC_IsAction { get; set; }
        public Nullable<bool> PROC_InPendenzen { get; set; }
        public Nullable<bool> PROC_IsFallBack { get; set; }
        public Nullable<System.Guid> PROC_FallBack_UID { get; set; }
        public Nullable<System.Guid> PROC_FallBack_UID2 { get; set; }
        public Nullable<System.Guid> PROC_SetDocStatus { get; set; }
        public int PROC_Status { get; set; }
        public int PROC_Sort { get; set; }
        public Nullable<int> PROC_StylizerFore { get; set; }
        public Nullable<int> PROC_StylizerBack { get; set; }
        public Nullable<int> PROC_StylizerPattern { get; set; }
        public Nullable<int> PROC_StylizerLine { get; set; }
        public bool PROC_IsDefault { get; set; }
        public Nullable<System.DateTime> PROC_DatumMut { get; set; }
        public string PROC_DatumUser { get; set; }
        public bool PROC_ShowVerantwortlicher { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_DMS_ZO_Prozesse_Berechtigungen> T_DMS_ZO_Prozesse_Berechtigungen { get; set; }
    }
}
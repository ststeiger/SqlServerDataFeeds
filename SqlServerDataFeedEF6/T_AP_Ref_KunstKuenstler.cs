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
    
    public partial class T_AP_Ref_KunstKuenstler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Ref_KunstKuenstler()
        {
            this.T_ZO_AP_Kunst_AP_Ref_KunstKuenstler = new HashSet<T_ZO_AP_Kunst_AP_Ref_KunstKuenstler>();
        }
    
        public System.Guid KK_UID { get; set; }
        public int KK_MDT_ID { get; set; }
        public Nullable<int> KK_Code { get; set; }
        public string KK_Kurz_DE { get; set; }
        public string KK_Kurz_FR { get; set; }
        public string KK_Kurz_IT { get; set; }
        public string KK_Kurz_EN { get; set; }
        public string KK_Lang_DE { get; set; }
        public string KK_Lang_FR { get; set; }
        public string KK_Lang_IT { get; set; }
        public string KK_Lang_EN { get; set; }
        public int KK_Status { get; set; }
        public int KK_Sort { get; set; }
        public Nullable<int> KK_StylizerFore { get; set; }
        public Nullable<int> KK_StylizerBack { get; set; }
        public Nullable<int> KK_StylizerPattern { get; set; }
        public Nullable<int> KK_StylizerLine { get; set; }
        public bool KK_IsDefault { get; set; }
        public Nullable<System.DateTime> KK_DatumMut { get; set; }
        public string KK_DatumUser { get; set; }
        public string KK_Biografie { get; set; }
        public Nullable<int> KK_Geburtsjahr { get; set; }
        public Nullable<int> KK_Todesjahr { get; set; }
        public string KK_Geburtsort { get; set; }
        public string KK_Todesort { get; set; }
        public Nullable<System.Guid> KK_GS_UID { get; set; }
        public string KK_Alias { get; set; }
        public Nullable<int> KK_Geburtstag { get; set; }
        public Nullable<int> KK_Geburtsmonat { get; set; }
        public Nullable<int> KK_Todestag { get; set; }
        public Nullable<int> KK_Todesmonat { get; set; }
        public Nullable<System.Guid> KK_Geburtsort_ORT_UID { get; set; }
        public Nullable<System.Guid> KK_Todesort_ORT_UID { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_AP_Ref_Ort T_AP_Ref_Ort { get; set; }
        public virtual T_AP_Ref_Ort T_AP_Ref_Ort1 { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        public virtual T_SYS_Ref_Geschlecht T_SYS_Ref_Geschlecht { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Kunst_AP_Ref_KunstKuenstler> T_ZO_AP_Kunst_AP_Ref_KunstKuenstler { get; set; }
    }
}

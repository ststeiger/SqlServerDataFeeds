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
    
    public partial class T_AP_Ref_SchluesselTyp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Ref_SchluesselTyp()
        {
            this.T_AP_Schluesselgruppe = new HashSet<T_AP_Schluesselgruppe>();
        }
    
        public System.Guid STYP_UID { get; set; }
        public int STYP_MDT_ID { get; set; }
        public Nullable<int> STYP_Code { get; set; }
        public string STYP_Kurz_DE { get; set; }
        public string STYP_Kurz_FR { get; set; }
        public string STYP_Kurz_IT { get; set; }
        public string STYP_Kurz_EN { get; set; }
        public string STYP_Lang_DE { get; set; }
        public string STYP_Lang_FR { get; set; }
        public string STYP_Lang_IT { get; set; }
        public string STYP_Lang_EN { get; set; }
        public int STYP_Status { get; set; }
        public int STYP_Sort { get; set; }
        public Nullable<int> STYP_StylizerFore { get; set; }
        public Nullable<int> STYP_StylizerBack { get; set; }
        public Nullable<int> STYP_StylizerPattern { get; set; }
        public Nullable<int> STYP_StylizerLine { get; set; }
        public bool STYP_IsDefault { get; set; }
        public Nullable<System.DateTime> STYP_DatumMut { get; set; }
        public string STYP_DatumUser { get; set; }
        public Nullable<int> STYP_FixKeyAmount { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Schluesselgruppe> T_AP_Schluesselgruppe { get; set; }
    }
}

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
    
    public partial class T_AP_Ref_FahrzeugHersteller
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Ref_FahrzeugHersteller()
        {
            this.T_AP_Fahrzeug = new HashSet<T_AP_Fahrzeug>();
        }
    
        public System.Guid FZHE_UID { get; set; }
        public int FZHE_MDT_ID { get; set; }
        public Nullable<int> FZHE_Code { get; set; }
        public string FZHE_Kurz_DE { get; set; }
        public string FZHE_Kurz_FR { get; set; }
        public string FZHE_Kurz_IT { get; set; }
        public string FZHE_Kurz_EN { get; set; }
        public string FZHE_Lang_DE { get; set; }
        public string FZHE_Lang_FR { get; set; }
        public string FZHE_Lang_IT { get; set; }
        public string FZHE_Lang_EN { get; set; }
        public int FZHE_Status { get; set; }
        public int FZHE_Sort { get; set; }
        public Nullable<int> FZHE_StylizerFore { get; set; }
        public Nullable<int> FZHE_StylizerBack { get; set; }
        public Nullable<int> FZHE_StylizerPattern { get; set; }
        public Nullable<int> FZHE_StylizerLine { get; set; }
        public bool FZHE_IsDefault { get; set; }
        public Nullable<System.DateTime> FZHE_DatumMut { get; set; }
        public string FZHE_DatumUser { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Fahrzeug> T_AP_Fahrzeug { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

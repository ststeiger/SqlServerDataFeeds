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
    
    public partial class T_AP_Ref_AussenobjektAnschlagkastenSchliessung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Ref_AussenobjektAnschlagkastenSchliessung()
        {
            this.T_AP_Aussenobjekt = new HashSet<T_AP_Aussenobjekt>();
        }
    
        public System.Guid AAKS_UID { get; set; }
        public int AAKS_MDT_ID { get; set; }
        public Nullable<int> AAKS_Code { get; set; }
        public string AAKS_Kurz_DE { get; set; }
        public string AAKS_Kurz_FR { get; set; }
        public string AAKS_Kurz_IT { get; set; }
        public string AAKS_Kurz_EN { get; set; }
        public string AAKS_Lang_DE { get; set; }
        public string AAKS_Lang_FR { get; set; }
        public string AAKS_Lang_IT { get; set; }
        public string AAKS_Lang_EN { get; set; }
        public int AAKS_Status { get; set; }
        public int AAKS_Sort { get; set; }
        public Nullable<int> AAKS_StylizerFore { get; set; }
        public Nullable<int> AAKS_StylizerBack { get; set; }
        public Nullable<int> AAKS_StylizerPattern { get; set; }
        public Nullable<int> AAKS_StylizerLine { get; set; }
        public bool AAKS_IsDefault { get; set; }
        public Nullable<System.DateTime> AAKS_DatumMut { get; set; }
        public string AAKS_DatumUser { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Aussenobjekt> T_AP_Aussenobjekt { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

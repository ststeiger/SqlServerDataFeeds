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
    
    public partial class T_AP_Ref_AussenobjektAnschlagkastenTyp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_AP_Ref_AussenobjektAnschlagkastenTyp()
        {
            this.T_AP_Aussenobjekt = new HashSet<T_AP_Aussenobjekt>();
        }
    
        public System.Guid AAKT_UID { get; set; }
        public int AAKT_MDT_ID { get; set; }
        public Nullable<int> AAKT_Code { get; set; }
        public string AAKT_Kurz_DE { get; set; }
        public string AAKT_Kurz_FR { get; set; }
        public string AAKT_Kurz_IT { get; set; }
        public string AAKT_Kurz_EN { get; set; }
        public string AAKT_Lang_DE { get; set; }
        public string AAKT_Lang_FR { get; set; }
        public string AAKT_Lang_IT { get; set; }
        public string AAKT_Lang_EN { get; set; }
        public int AAKT_Status { get; set; }
        public int AAKT_Sort { get; set; }
        public Nullable<int> AAKT_StylizerFore { get; set; }
        public Nullable<int> AAKT_StylizerBack { get; set; }
        public Nullable<int> AAKT_StylizerPattern { get; set; }
        public Nullable<int> AAKT_StylizerLine { get; set; }
        public bool AAKT_IsDefault { get; set; }
        public Nullable<System.DateTime> AAKT_DatumMut { get; set; }
        public string AAKT_DatumUser { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Aussenobjekt> T_AP_Aussenobjekt { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

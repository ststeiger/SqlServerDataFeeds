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
    
    public partial class T_POM_Ref_MittelwertGruppe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_POM_Ref_MittelwertGruppe()
        {
            this.T_POM_Mittelwert = new HashSet<T_POM_Mittelwert>();
        }
    
        public System.Guid MWG_UID { get; set; }
        public int MWG_MDT_ID { get; set; }
        public string MWG_Code { get; set; }
        public Nullable<int> MWG_ReportKey { get; set; }
        public string MWG_Kurz_DE { get; set; }
        public string MWG_Kurz_FR { get; set; }
        public string MWG_Kurz_IT { get; set; }
        public string MWG_Kurz_EN { get; set; }
        public string MWG_Lang_DE { get; set; }
        public string MWG_Lang_FR { get; set; }
        public string MWG_Lang_IT { get; set; }
        public string MWG_Lang_EN { get; set; }
        public int MWG_Status { get; set; }
        public int MWG_Sort { get; set; }
        public Nullable<int> MWG_StylizerFore { get; set; }
        public Nullable<int> MWG_StylizerBack { get; set; }
        public Nullable<int> MWG_StylizerPattern { get; set; }
        public Nullable<int> MWG_StylizerLine { get; set; }
        public bool MWG_IsDefault { get; set; }
        public Nullable<System.DateTime> MWG_DatumMut { get; set; }
        public string MWG_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_POM_Mittelwert> T_POM_Mittelwert { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

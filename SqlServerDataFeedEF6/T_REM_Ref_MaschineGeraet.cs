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
    
    public partial class T_REM_Ref_MaschineGeraet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_REM_Ref_MaschineGeraet()
        {
            this.T_REM_Ref_Arbeitsgang = new HashSet<T_REM_Ref_Arbeitsgang>();
        }
    
        public System.Guid REMMG_UID { get; set; }
        public Nullable<int> REMMG_Code { get; set; }
        public string REMMG_Kurz_de { get; set; }
        public string REMMG_Kurz_fr { get; set; }
        public string REMMG_Kurz_it { get; set; }
        public string REMMG_Kurz_en { get; set; }
        public string REMMG_Lang_de { get; set; }
        public string REMMG_Lang_fr { get; set; }
        public string REMMG_Lang_it { get; set; }
        public string REMMG_Lang_en { get; set; }
        public int REMMG_Status { get; set; }
        public int REMMG_Sort { get; set; }
        public bool REMMG_IsDefault { get; set; }
        public Nullable<int> REMMG_StylizerBack { get; set; }
        public Nullable<int> REMMG_StylizerFore { get; set; }
        public Nullable<int> REMMG_StylizerPattern { get; set; }
        public Nullable<int> REMMG_StylizerLine { get; set; }
        public string REMMG_Bild { get; set; }
        public Nullable<int> REMMG_BildWidth { get; set; }
        public Nullable<int> REMMG_BildHeight { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_REM_Ref_Arbeitsgang> T_REM_Ref_Arbeitsgang { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

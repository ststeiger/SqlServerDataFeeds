//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SqlServerDataFeed
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_DMS_Ref_DokumentArt
    {
        public T_DMS_Ref_DokumentArt()
        {
            this.T_DMS_Dokument = new HashSet<T_DMS_Dokument>();
        }
    
        public System.Guid DA_UID { get; set; }
        public Nullable<System.Guid> DA_DG_UID { get; set; }
        public string DA_Code { get; set; }
        public string DA_Kurz_DE { get; set; }
        public string DA_Kurz_FR { get; set; }
        public string DA_Kurz_IT { get; set; }
        public string DA_Kurz_EN { get; set; }
        public string DA_Lang_DE { get; set; }
        public string DA_Lang_FR { get; set; }
        public string DA_Lang_IT { get; set; }
        public string DA_Lang_EN { get; set; }
        public int DA_Status { get; set; }
        public int DA_Sort { get; set; }
        public Nullable<int> DA_StylizerFore { get; set; }
        public Nullable<int> DA_StylizerBack { get; set; }
        public Nullable<int> DA_StylizerPattern { get; set; }
        public Nullable<int> DA_StylizerLine { get; set; }
        public bool DA_IsDefault { get; set; }
        public Nullable<System.DateTime> DA_DatumMut { get; set; }
        public string DA_DatumUser { get; set; }
    
        public virtual ICollection<T_DMS_Dokument> T_DMS_Dokument { get; set; }
        public virtual T_DMS_Ref_DokumentGruppe T_DMS_Ref_DokumentGruppe { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}
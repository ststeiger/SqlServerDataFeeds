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
    
    public partial class T_DMS_Ref_DokumentTyp
    {
        public T_DMS_Ref_DokumentTyp()
        {
            this.T_DMS_Dokument = new HashSet<T_DMS_Dokument>();
            this.T_DMS_SYS_MetaStruktur = new HashSet<T_DMS_SYS_MetaStruktur>();
        }
    
        public System.Guid DT_UID { get; set; }
        public Nullable<int> DT_Code { get; set; }
        public string DT_Kurz_DE { get; set; }
        public string DT_Kurz_FR { get; set; }
        public string DT_Kurz_IT { get; set; }
        public string DT_Kurz_EN { get; set; }
        public string DT_Lang_DE { get; set; }
        public string DT_Lang_FR { get; set; }
        public string DT_Lang_IT { get; set; }
        public string DT_Lang_EN { get; set; }
        public int DT_Status { get; set; }
        public int DT_Sort { get; set; }
        public Nullable<int> DT_StylizerFore { get; set; }
        public Nullable<int> DT_StylizerBack { get; set; }
        public Nullable<int> DT_StylizerPattern { get; set; }
        public Nullable<int> DT_StylizerLine { get; set; }
        public bool DT_IsDefault { get; set; }
        public Nullable<System.DateTime> DT_DatumMut { get; set; }
        public string DT_DatumUser { get; set; }
    
        public virtual ICollection<T_DMS_Dokument> T_DMS_Dokument { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        public virtual ICollection<T_DMS_SYS_MetaStruktur> T_DMS_SYS_MetaStruktur { get; set; }
    }
}
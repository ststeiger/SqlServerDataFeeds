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
    
    public partial class T_SYS_Ref_BackOfficeMenue
    {
        public T_SYS_Ref_BackOfficeMenue()
        {
            this.T_SYS_Ref_BackOfficeSubMenue = new HashSet<T_SYS_Ref_BackOfficeSubMenue>();
        }
    
        public System.Guid BOM_UID { get; set; }
        public Nullable<int> BOM_Code { get; set; }
        public string BOM_Kurz_DE { get; set; }
        public string BOM_Kurz_FR { get; set; }
        public string BOM_Kurz_IT { get; set; }
        public string BOM_Kurz_EN { get; set; }
        public string BOM_Lang_DE { get; set; }
        public string BOM_Lang_FR { get; set; }
        public string BOM_Lang_IT { get; set; }
        public string BOM_Lang_EN { get; set; }
        public int BOM_Status { get; set; }
        public int BOM_Sort { get; set; }
        public Nullable<int> BOM_StylizerFore { get; set; }
        public Nullable<int> BOM_StylizerBack { get; set; }
        public Nullable<int> BOM_StylizerPattern { get; set; }
        public Nullable<int> BOM_StylizerLine { get; set; }
        public bool BOM_IsDefault { get; set; }
    
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        public virtual ICollection<T_SYS_Ref_BackOfficeSubMenue> T_SYS_Ref_BackOfficeSubMenue { get; set; }
    }
}

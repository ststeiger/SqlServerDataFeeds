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
    
    public partial class T_REM_Ref_RaumName
    {
        public T_REM_Ref_RaumName()
        {
            this.T_ZO_REM_AP_Raum_Ausstattung_Kalk = new HashSet<T_ZO_REM_AP_Raum_Ausstattung_Kalk>();
            this.T_ZO_REM_AP_Raum_Ausstattung = new HashSet<T_ZO_REM_AP_Raum_Ausstattung>();
        }
    
        public System.Guid REMRN_UID { get; set; }
        public string REMRN_Code { get; set; }
        public string REMRN_Kurz_de { get; set; }
        public string REMRN_Kurz_fr { get; set; }
        public string REMRN_Kurz_it { get; set; }
        public string REMRN_Kurz_en { get; set; }
        public string REMRN_Lang_de { get; set; }
        public string REMRN_Lang_fr { get; set; }
        public string REMRN_Lang_it { get; set; }
        public string REMRN_Lang_en { get; set; }
        public int REMRN_Status { get; set; }
        public int REMRN_Sort { get; set; }
        public bool REMRN_IsDefault { get; set; }
        public Nullable<int> REMRN_StylizerBack { get; set; }
        public Nullable<int> REMRN_StylizerFore { get; set; }
        public Nullable<int> REMRN_StylizerPattern { get; set; }
        public Nullable<int> REMRN_StylizerLine { get; set; }
    
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        public virtual ICollection<T_ZO_REM_AP_Raum_Ausstattung_Kalk> T_ZO_REM_AP_Raum_Ausstattung_Kalk { get; set; }
        public virtual ICollection<T_ZO_REM_AP_Raum_Ausstattung> T_ZO_REM_AP_Raum_Ausstattung { get; set; }
    }
}

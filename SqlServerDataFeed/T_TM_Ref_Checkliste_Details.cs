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
    
    public partial class T_TM_Ref_Checkliste_Details
    {
        public T_TM_Ref_Checkliste_Details()
        {
            this.T_TM_Tasks_Checkpoints = new HashSet<T_TM_Tasks_Checkpoints>();
            this.T_TM_Tasks_Planung_Checkpoints = new HashSet<T_TM_Tasks_Planung_Checkpoints>();
        }
    
        public System.Guid TCLD_UID { get; set; }
        public int TCLD_MDT_ID { get; set; }
        public Nullable<int> TCLD_Code { get; set; }
        public string TCLD_Kurz_DE { get; set; }
        public string TCLD_Kurz_FR { get; set; }
        public string TCLD_Kurz_IT { get; set; }
        public string TCLD_Kurz_EN { get; set; }
        public string TCLD_Lang_DE { get; set; }
        public string TCLD_Lang_FR { get; set; }
        public string TCLD_Lang_IT { get; set; }
        public string TCLD_Lang_EN { get; set; }
        public int TCLD_Status { get; set; }
        public int TCLD_Sort { get; set; }
        public Nullable<int> TCLD_StylizerFore { get; set; }
        public Nullable<int> TCLD_StylizerBack { get; set; }
        public Nullable<int> TCLD_StylizerPattern { get; set; }
        public Nullable<int> TCLD_StylizerLine { get; set; }
        public bool TCLD_IsDefault { get; set; }
        public Nullable<System.DateTime> TCLD_DatumMut { get; set; }
        public string TCLD_DatumUser { get; set; }
        public Nullable<System.Guid> TCLD_TCL_UID { get; set; }
        public bool TCLD_isCheckbox { get; set; }
        public bool TCLD_isTextbox { get; set; }
        public Nullable<System.Guid> TCLD_TCLA_UID { get; set; }
        public Nullable<System.Guid> TCLD_TPL_UID { get; set; }
        public Nullable<System.Guid> TCLD_TCLWA_UID { get; set; }
        public Nullable<System.Guid> TCLD_TCLTA_UID { get; set; }
        public Nullable<bool> TCLD_isLabel { get; set; }
        public Nullable<int> TCLD_Colspan { get; set; }
        public Nullable<bool> TCLD_isTaskbox { get; set; }
        public Nullable<bool> TCLD_isDropDown { get; set; }
        public string TCLD_cssClass { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        public virtual T_TM_Ref_Checkliste T_TM_Ref_Checkliste { get; set; }
        public virtual T_TM_Ref_Checkliste_Absatz T_TM_Ref_Checkliste_Absatz { get; set; }
        public virtual T_TM_Ref_Checkliste_Taetigkeit T_TM_Ref_Checkliste_Taetigkeit { get; set; }
        public virtual T_TM_Ref_Checkliste_Wartung T_TM_Ref_Checkliste_Wartung { get; set; }
        public virtual T_TM_Tasks_Planung T_TM_Tasks_Planung { get; set; }
        public virtual ICollection<T_TM_Tasks_Checkpoints> T_TM_Tasks_Checkpoints { get; set; }
        public virtual ICollection<T_TM_Tasks_Planung_Checkpoints> T_TM_Tasks_Planung_Checkpoints { get; set; }
    }
}

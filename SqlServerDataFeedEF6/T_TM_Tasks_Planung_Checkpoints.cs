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
    
    public partial class T_TM_Tasks_Planung_Checkpoints
    {
        public System.Guid TPLCP_UID { get; set; }
        public System.Guid TPLCP_TPL_UID { get; set; }
        public System.Guid TPLCP_TCLD_UID { get; set; }
        public bool TPLCP_Check01 { get; set; }
        public bool TPLCP_Check02 { get; set; }
        public bool TPLCP_Check03 { get; set; }
        public bool TPLCP_Check04 { get; set; }
        public bool TPLCP_Check05 { get; set; }
        public bool TPLCP_Check06 { get; set; }
        public bool TPLCP_Check07 { get; set; }
        public string TPLCP_Text01 { get; set; }
        public string TPLCP_Text02 { get; set; }
        public string TPLCP_Text03 { get; set; }
        public string TPLCP_Text04 { get; set; }
        public string TPLCP_Text05 { get; set; }
        public string TPLCP_Text06 { get; set; }
        public string TPLCP_Text07 { get; set; }
        public int TPLCP_Status { get; set; }
    
        public virtual T_TM_Ref_Checkliste_Details T_TM_Ref_Checkliste_Details { get; set; }
        public virtual T_TM_Tasks_Planung T_TM_Tasks_Planung { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SqlServerDataFeed
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_TM_Tasks_Checkpoints
    {
        public System.Guid TSKCP_UID { get; set; }
        public System.Guid TSKCP_TSK_UID { get; set; }
        public System.Guid TSKCP_TCLD_UID { get; set; }
        public bool TSKCP_Check01 { get; set; }
        public bool TSKCP_Check02 { get; set; }
        public bool TSKCP_Check03 { get; set; }
        public bool TSKCP_Check04 { get; set; }
        public bool TSKCP_Check05 { get; set; }
        public string TSKCP_Text01 { get; set; }
        public string TSKCP_Text02 { get; set; }
        public string TSKCP_Text03 { get; set; }
        public string TSKCP_Text04 { get; set; }
        public string TSKCP_Text05 { get; set; }
        public string TSKCP_Text06 { get; set; }
        public string TSKCP_Text07 { get; set; }
        public bool TSKCP_Check06 { get; set; }
        public bool TSKCP_Check07 { get; set; }
        public int TSKCP_Status { get; set; }
    
        public virtual T_TM_Ref_Checkliste_Details T_TM_Ref_Checkliste_Details { get; set; }
        public virtual T_TM_Tasks T_TM_Tasks { get; set; }
    }
}

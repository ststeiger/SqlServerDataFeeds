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
    
    public partial class T_ZO_TM_TSTA_TSK
    {
        public System.Guid TSTATSK_UID { get; set; }
        public System.Guid TSTATSK_TSK_UID { get; set; }
        public System.Guid TSTATSK_TSTA_UID { get; set; }
        public System.DateTime TSTATSK_Date { get; set; }
    
        public virtual T_TM_Ref_TaskStatus T_TM_Ref_TaskStatus { get; set; }
        public virtual T_TM_Tasks T_TM_Tasks { get; set; }
    }
}

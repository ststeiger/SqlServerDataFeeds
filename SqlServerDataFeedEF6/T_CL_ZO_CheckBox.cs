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
    
    public partial class T_CL_ZO_CheckBox
    {
        public System.Guid ZOCLCB_UID { get; set; }
        public Nullable<System.Guid> ZOCLCB_ZOCLTH_UID { get; set; }
        public Nullable<System.Guid> ZOCLCB_ZOCLTD_UID { get; set; }
        public int ZOCLCB_MDT_ID { get; set; }
        public Nullable<bool> ZOCLCB_Checked { get; set; }
        public string ZOCLCB_Lang_DE { get; set; }
        public string ZOCLCB_Lang_FR { get; set; }
        public string ZOCLCB_Lang_IT { get; set; }
        public string ZOCLCB_Lang_EN { get; set; }
        public int ZOCLCB_Status { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_CL_ZO_Cell T_CL_ZO_Cell { get; set; }
        public virtual T_CL_ZO_Header T_CL_ZO_Header { get; set; }
    }
}
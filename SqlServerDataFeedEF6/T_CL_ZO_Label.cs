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
    
    public partial class T_CL_ZO_Label
    {
        public System.Guid ZOCLLA_UID { get; set; }
        public Nullable<System.Guid> ZOCLLA_ZOCLTH_UID { get; set; }
        public Nullable<System.Guid> ZOCLLA_ZOCLTD_UID { get; set; }
        public int ZOCLLA_MDT_ID { get; set; }
        public string ZOCLLA_Lang_DE { get; set; }
        public string ZOCLLA_Lang_FR { get; set; }
        public string ZOCLLA_Lang_IT { get; set; }
        public string ZOCLLA_Lang_EN { get; set; }
        public string ZOCLLA_Align { get; set; }
        public int ZOCLLA_Status { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_CL_ZO_Cell T_CL_ZO_Cell { get; set; }
        public virtual T_CL_ZO_Header T_CL_ZO_Header { get; set; }
    }
}

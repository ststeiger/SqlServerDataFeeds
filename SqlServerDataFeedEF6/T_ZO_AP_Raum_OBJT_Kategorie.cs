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
    
    public partial class T_ZO_AP_Raum_OBJT_Kategorie
    {
        public System.Guid ZO_RMOBJTKAT_UID { get; set; }
        public System.Guid ZO_RMOBJTKAT_RM_UID { get; set; }
        public System.Guid ZO_RMOBJTKAT_OBJTKAT_UID { get; set; }
        public int ZO_RMOBJTKAT_Status { get; set; }
        public string ZO_RMOBJTKAT_Nr { get; set; }
        public string ZO_RMOBJTKAT_Amount { get; set; }
    
        public virtual T_AP_Raum T_AP_Raum { get; set; }
    }
}
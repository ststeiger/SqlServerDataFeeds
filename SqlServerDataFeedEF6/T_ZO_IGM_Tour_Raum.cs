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
    
    public partial class T_ZO_IGM_Tour_Raum
    {
        public System.Guid ZOTR_UID { get; set; }
        public Nullable<System.Guid> ZOTR_TR_UID { get; set; }
        public Nullable<System.Guid> ZOTR_RM_UID { get; set; }
        public Nullable<bool> ZOTR_Montag { get; set; }
        public Nullable<bool> ZOTR_Dienstag { get; set; }
        public Nullable<bool> ZOTR_Mittwoch { get; set; }
        public Nullable<bool> ZOTR_Donnerstag { get; set; }
        public Nullable<bool> ZOTR_Freitag { get; set; }
        public Nullable<bool> ZOTR_Samstag { get; set; }
        public Nullable<bool> ZOTR_Sonntag { get; set; }
        public Nullable<bool> ZOTR_UW { get; set; }
        public Nullable<bool> ZOTR_SIR { get; set; }
        public Nullable<bool> ZOTR_GLR { get; set; }
        public Nullable<bool> ZOTR_TD { get; set; }
        public Nullable<bool> ZOTR_Multi { get; set; }
        public Nullable<int> ZOTR_Status { get; set; }
    
        public virtual T_AP_Raum T_AP_Raum { get; set; }
        public virtual T_IGM_Tour T_IGM_Tour { get; set; }
    }
}

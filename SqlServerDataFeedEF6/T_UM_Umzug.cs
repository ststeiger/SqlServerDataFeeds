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
    
    public partial class T_UM_Umzug
    {
        public System.Guid UMU_UID { get; set; }
        public System.Guid UMU_UMP_UID { get; set; }
        public System.Guid UMU_KT_UID { get; set; }
        public Nullable<System.Guid> UMU_ZO_APBEL_UID { get; set; }
        public Nullable<System.Guid> UMU_SO_UID { get; set; }
        public Nullable<System.Guid> UMU_GB_UID { get; set; }
        public Nullable<System.Guid> UMU_TK_UID { get; set; }
        public Nullable<System.Guid> UMU_GS_UID { get; set; }
        public Nullable<System.Guid> UMU_RM_UID { get; set; }
        public Nullable<System.Guid> UMU_AP_UID { get; set; }
        public int UMU_Status { get; set; }
        public Nullable<System.DateTime> UMU_UmzugDatum { get; set; }
        public Nullable<int> UMU_Phase { get; set; }
        public string UMU_UmzugZeit { get; set; }
        public Nullable<System.Guid> UMU_SO_UID_old { get; set; }
        public Nullable<System.Guid> UMU_GB_UID_old { get; set; }
        public Nullable<System.Guid> UMU_TK_UID_old { get; set; }
        public Nullable<System.Guid> UMU_GS_UID_old { get; set; }
        public Nullable<System.Guid> UMU_RM_UID_old { get; set; }
        public Nullable<System.Guid> UMU_AP_UID_old { get; set; }
        public Nullable<int> UMU_Sort { get; set; }
        public Nullable<double> UMU_Beschaeftigungsgrad { get; set; }
        public Nullable<System.Guid> UMU_APBEL_UID { get; set; }
    
        public virtual T_AP_Arbeitsplatz T_AP_Arbeitsplatz { get; set; }
        public virtual T_AP_Gebaeude T_AP_Gebaeude { get; set; }
        public virtual T_AP_Geschoss T_AP_Geschoss { get; set; }
        public virtual T_AP_Kontakte T_AP_Kontakte { get; set; }
        public virtual T_AP_Raum T_AP_Raum { get; set; }
        public virtual T_AP_Standort T_AP_Standort { get; set; }
        public virtual T_AP_Trakt T_AP_Trakt { get; set; }
        public virtual T_UM_Planung T_UM_Planung { get; set; }
        public virtual T_ZO_AP_Arbeitsplatz_AP_Belegung T_ZO_AP_Arbeitsplatz_AP_Belegung { get; set; }
    }
}

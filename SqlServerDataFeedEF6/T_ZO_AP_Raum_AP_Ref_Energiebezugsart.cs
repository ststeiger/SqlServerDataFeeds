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
    
    public partial class T_ZO_AP_Raum_AP_Ref_Energiebezugsart
    {
        public System.Guid ZO_RMEBA_UID { get; set; }
        public System.Guid ZO_RMEBA_RM_UID { get; set; }
        public System.Guid ZO_RMEBA_EBA_UID { get; set; }
        public System.DateTime ZO_RMEBA_DatumVon { get; set; }
        public System.DateTime ZO_RMEBA_DatumBis { get; set; }
        public int ZO_RMEBA_Status { get; set; }
    
        public virtual T_AP_Raum T_AP_Raum { get; set; }
        public virtual T_AP_Ref_Energiebezugsart T_AP_Ref_Energiebezugsart { get; set; }
    }
}

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
    
    public partial class T_ZO_AP_Standort_DWG
    {
        public System.Guid ZO_SODWG_UID { get; set; }
        public System.Guid ZO_SODWG_SO_UID { get; set; }
        public string ZO_SODWG_ApertureDWG { get; set; }
        public System.DateTime ZO_SODWG_DatumVon { get; set; }
        public System.DateTime ZO_SODWG_DatumBis { get; set; }
        public string ZO_SODWG_ApertureObjID { get; set; }
        public int ZO_SODWG_Status { get; set; }
        public string ZO_SODWG_DWGID { get; set; }
    
        public virtual T_AP_Standort T_AP_Standort { get; set; }
    }
}

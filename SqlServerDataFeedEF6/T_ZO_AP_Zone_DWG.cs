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
    
    public partial class T_ZO_AP_Zone_DWG
    {
        public System.Guid ZO_ZNDWG_UID { get; set; }
        public System.Guid ZO_ZNDWG_ZN_UID { get; set; }
        public string ZO_ZNDWG_ApertureDWG { get; set; }
        public System.DateTime ZO_ZNDWG_DatumVon { get; set; }
        public System.DateTime ZO_ZNDWG_DatumBis { get; set; }
        public string ZO_ZNDWG_ApertureObjID { get; set; }
        public int ZO_ZNDWG_Status { get; set; }
    
        public virtual T_AP_Zone T_AP_Zone { get; set; }
    }
}

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
    
    public partial class T_ZO_AP_Grundstueck_DWG
    {
        public System.Guid ZO_GRUDWG_UID { get; set; }
        public System.Guid ZO_GRUDWG_GRU_UID { get; set; }
        public string ZO_GRUDWG_ApertureDWG { get; set; }
        public System.DateTime ZO_GRUDWG_DatumVon { get; set; }
        public System.DateTime ZO_GRUDWG_DatumBis { get; set; }
        public string ZO_GRUDWG_ApertureObjID { get; set; }
        public int ZO_GRUDWG_Status { get; set; }
        public string ZO_GRUDWG_DWGID { get; set; }
    
        public virtual T_AP_Grundstueck T_AP_Grundstueck { get; set; }
    }
}
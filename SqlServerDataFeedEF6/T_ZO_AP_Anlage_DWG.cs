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
    
    public partial class T_ZO_AP_Anlage_DWG
    {
        public System.Guid ZO_ALDWG_UID { get; set; }
        public System.Guid ZO_ALDWG_AL_UID { get; set; }
        public string ZO_ALDWG_ApertureDWG { get; set; }
        public System.DateTime ZO_ALDWG_DatumVon { get; set; }
        public System.DateTime ZO_ALDWG_DatumBis { get; set; }
        public string ZO_ALDWG_ApertureObjID { get; set; }
        public int ZO_ALDWG_Status { get; set; }
        public string ZO_ALDWG_DWGID { get; set; }
    
        public virtual T_AP_Anlage T_AP_Anlage { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SqlServerDataFeed
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_ZO_AP_Geschoss_DWG
    {
        public System.Guid ZO_GSDWG_UID { get; set; }
        public System.Guid ZO_GSDWG_GS_UID { get; set; }
        public string ZO_GSDWG_ApertureDWG { get; set; }
        public System.DateTime ZO_GSDWG_DatumVon { get; set; }
        public System.DateTime ZO_GSDWG_DatumBis { get; set; }
        public string ZO_GSDWG_ApertureObjID { get; set; }
        public int ZO_GSDWG_Status { get; set; }
        public string ZO_GSDWG_DWGID { get; set; }
    
        public virtual T_AP_Geschoss T_AP_Geschoss { get; set; }
    }
}

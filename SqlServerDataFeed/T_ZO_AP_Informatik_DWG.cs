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
    
    public partial class T_ZO_AP_Informatik_DWG
    {
        public System.Guid ZO_INDWG_UID { get; set; }
        public System.Guid ZO_INDWG_IN_UID { get; set; }
        public string ZO_INDWG_ApertureDWG { get; set; }
        public System.DateTime ZO_INDWG_DatumVon { get; set; }
        public System.DateTime ZO_INDWG_DatumBis { get; set; }
        public string ZO_INDWG_ApertureObjID { get; set; }
        public int ZO_INDWG_Status { get; set; }
        public string ZO_INDWG_DWGID { get; set; }
    
        public virtual T_AP_Informatik T_AP_Informatik { get; set; }
    }
}

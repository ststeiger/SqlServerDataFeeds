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
    
    public partial class T_ZO_AP_Tuer_Schliessung
    {
        public System.Guid ZO_TRSC_UID { get; set; }
        public System.Guid ZO_TRSC_TR_UID { get; set; }
        public Nullable<System.Guid> ZO_TRSC_ST_UID { get; set; }
        public string ZO_TRSC_Zylinder_Nr { get; set; }
        public System.DateTime ZO_TRSC_DatumVon { get; set; }
        public System.DateTime ZO_TRSC_DatumBis { get; set; }
        public string ZO_TRSC_Status { get; set; }
    
        public virtual T_AP_Ref_Schliessungstyp T_AP_Ref_Schliessungstyp { get; set; }
        public virtual T_AP_Tuer T_AP_Tuer { get; set; }
        public virtual T_ZO_AP_Tuer_Schliessung T_ZO_AP_Tuer_Schliessung1 { get; set; }
        public virtual T_ZO_AP_Tuer_Schliessung T_ZO_AP_Tuer_Schliessung2 { get; set; }
    }
}

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
    
    public partial class T_ZO_AP_Gebaeude_Flaeche
    {
        public System.Guid ZO_GBFlaeche_UID { get; set; }
        public System.Guid ZO_GBFlaeche_GB_UID { get; set; }
        public Nullable<double> ZO_GBFlaeche_Flaeche { get; set; }
        public System.DateTime ZO_GBFlaeche_DatumVon { get; set; }
        public System.DateTime ZO_GBFlaeche_DatumBis { get; set; }
        public int ZO_GBFlaeche_Status { get; set; }
    
        public virtual T_AP_Gebaeude T_AP_Gebaeude { get; set; }
    }
}

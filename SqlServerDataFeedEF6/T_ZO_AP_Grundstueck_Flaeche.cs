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
    
    public partial class T_ZO_AP_Grundstueck_Flaeche
    {
        public System.Guid ZO_GRUFlaeche_UID { get; set; }
        public System.Guid ZO_GRUFlaeche_GRU_UID { get; set; }
        public Nullable<double> ZO_GRUFlaeche_Flaeche { get; set; }
        public System.DateTime ZO_GRUFlaeche_DatumVon { get; set; }
        public System.DateTime ZO_GRUFlaeche_DatumBis { get; set; }
        public int ZO_GRUFlaeche_Status { get; set; }
    
        public virtual T_AP_Grundstueck T_AP_Grundstueck { get; set; }
    }
}

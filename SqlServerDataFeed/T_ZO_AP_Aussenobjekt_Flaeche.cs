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
    
    public partial class T_ZO_AP_Aussenobjekt_Flaeche
    {
        public System.Guid ZO_AOFlaeche_UID { get; set; }
        public System.Guid ZO_AOFlaeche_AO_UID { get; set; }
        public Nullable<double> ZO_AOFlaeche_Flaeche { get; set; }
        public System.DateTime ZO_AOFlaeche_DatumVon { get; set; }
        public System.DateTime ZO_AOFlaeche_DatumBis { get; set; }
        public int ZO_AOFlaeche_Status { get; set; }
    
        public virtual T_AP_Aussenobjekt T_AP_Aussenobjekt { get; set; }
    }
}

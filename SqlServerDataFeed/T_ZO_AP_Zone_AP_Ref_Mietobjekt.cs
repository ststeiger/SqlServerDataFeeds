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
    
    public partial class T_ZO_AP_Zone_AP_Ref_Mietobjekt
    {
        public System.Guid ZO_ZNMIO_UID { get; set; }
        public System.Guid ZO_ZNMIO_ZN_UID { get; set; }
        public System.Guid ZO_ZNMIO_MIO_UID { get; set; }
        public System.DateTime ZO_ZNMIO_DatumVon { get; set; }
        public System.DateTime ZO_ZNMIO_DatumBis { get; set; }
        public int ZO_ZNMIO_Status { get; set; }
        public string ZO_ZNMIO_Bemerkung { get; set; }
        public double ZO_ZNMIO_FlaecheProzent { get; set; }
        public Nullable<double> ZO_ZNMIO_Flaeche { get; set; }
    
        public virtual T_AP_Ref_Mietobjekt T_AP_Ref_Mietobjekt { get; set; }
        public virtual T_AP_Zone T_AP_Zone { get; set; }
    }
}

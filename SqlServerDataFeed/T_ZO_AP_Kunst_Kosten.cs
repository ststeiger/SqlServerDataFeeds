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
    
    public partial class T_ZO_AP_Kunst_Kosten
    {
        public System.Guid ZO_KUKO_UID { get; set; }
        public System.Guid ZO_KUKO_KU_UID { get; set; }
        public System.DateTime ZO_KUKO_Datum { get; set; }
        public double ZO_KUKO_Kosten { get; set; }
        public string ZO_KUKO_Bemerkung { get; set; }
        public int ZO_KUKO_Status { get; set; }
    
        public virtual T_AP_Kunst T_AP_Kunst { get; set; }
    }
}

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
    
    public partial class T_DMS_ZO_Standort_Sprache
    {
        public System.Guid ZO_STAND_Sprache_UID { get; set; }
        public int ZO_STAND_Sprache_BG_ID { get; set; }
        public string ZO_STAND_Sprache { get; set; }
        public string ZO_STAND_Sprache_Bez { get; set; }
        public int ZO_Status { get; set; }
    
        public virtual T_Benutzergruppen T_Benutzergruppen { get; set; }
    }
}

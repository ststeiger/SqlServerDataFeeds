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
    
    public partial class T_ZO_AP_Kunst_Ausleihe
    {
        public System.Guid ZO_KUAL_UID { get; set; }
        public int ZO_KUAL_MDT_ID { get; set; }
        public System.Guid ZO_KUAL_KU_UID { get; set; }
        public Nullable<System.Guid> ZO_KUAL_KAART_UID { get; set; }
        public Nullable<System.Guid> ZO_KUAL_KAAN_UID { get; set; }
        public Nullable<System.Guid> ZO_KUAL_KIN_UID { get; set; }
        public string ZO_KUAL_Titel { get; set; }
        public Nullable<System.DateTime> ZO_KUAL_DatumVon { get; set; }
        public Nullable<System.DateTime> ZO_KUAL_DatumBis { get; set; }
        public Nullable<int> ZO_KUAL_Status { get; set; }
    
        public virtual T_AP_Kunst T_AP_Kunst { get; set; }
        public virtual T_AP_Ref_KunstAusleihanlass T_AP_Ref_KunstAusleihanlass { get; set; }
        public virtual T_AP_Ref_KunstAusleihart T_AP_Ref_KunstAusleihart { get; set; }
        public virtual T_AP_Ref_KunstInstitution T_AP_Ref_KunstInstitution { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
    }
}

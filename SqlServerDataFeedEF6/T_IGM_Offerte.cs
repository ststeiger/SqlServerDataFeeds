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
    
    public partial class T_IGM_Offerte
    {
        public System.Guid OF_UID { get; set; }
        public Nullable<System.Guid> OF_SO_UID { get; set; }
        public Nullable<System.Guid> OF_OT_UID { get; set; }
        public Nullable<int> OF_Nr { get; set; }
        public string OF_Bezeichnung { get; set; }
        public Nullable<double> OF_FaktorKWE { get; set; }
        public string OF_Bemerkungen { get; set; }
        public System.DateTime OF_DatumErstellt { get; set; }
        public Nullable<System.DateTime> OF_DatumVon { get; set; }
        public Nullable<System.DateTime> OF_DatumBis { get; set; }
        public Nullable<bool> OF_IsFixed { get; set; }
        public Nullable<bool> OF_IsSent { get; set; }
        public Nullable<bool> OF_IsOfferteWE { get; set; }
        public Nullable<bool> OF_IsGesperrt { get; set; }
        public Nullable<bool> OF_IsProv { get; set; }
        public Nullable<int> OF_Status { get; set; }
    
        public virtual T_AP_Standort T_AP_Standort { get; set; }
        public virtual T_IGM_Ref_OffertenTyp T_IGM_Ref_OffertenTyp { get; set; }
    }
}

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
    
    public partial class T_ZO_AP_Ref_Organisationseinheit_AP_Ref_Kostenstelle
    {
        public System.Guid ZO_KOEKST_UID { get; set; }
        public System.Guid ZO_KOEKST_KOE_UID { get; set; }
        public System.Guid ZO_KOEKST_KST_UID { get; set; }
        public System.DateTime ZO_KOEKST_DatumVon { get; set; }
        public System.DateTime ZO_KOEKST_DatumBis { get; set; }
        public int ZO_KOEKST_Status { get; set; }
        public string ZO_KOEKST_Bemerkung { get; set; }
        public Nullable<bool> ZO_KOEKST_IsFromOdis { get; set; }
    
        public virtual T_AP_Ref_Kostenstelle T_AP_Ref_Kostenstelle { get; set; }
        public virtual T_AP_Ref_Organisationseinheit T_AP_Ref_Organisationseinheit { get; set; }
    }
}

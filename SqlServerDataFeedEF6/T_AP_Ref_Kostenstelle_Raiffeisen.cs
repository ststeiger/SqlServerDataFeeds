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
    
    public partial class T_AP_Ref_Kostenstelle_Raiffeisen
    {
        public System.Guid KST_UID { get; set; }
        public System.Guid KST_KST_UID { get; set; }
        public string KST_Leiter_Name { get; set; }
        public string KST_Leiter_Vorname { get; set; }
        public Nullable<System.DateTime> KST_Eroeffnung { get; set; }
        public Nullable<System.DateTime> KST_Loeschen { get; set; }
        public string KST_Bemerkung { get; set; }
        public int KST_Status { get; set; }
    
        public virtual T_AP_Ref_Kostenstelle T_AP_Ref_Kostenstelle { get; set; }
    }
}

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
    
    public partial class T_POM_Mittelwert
    {
        public System.Guid MW_UID { get; set; }
        public int MW_MDT_ID { get; set; }
        public System.Guid MW_MWG_UID { get; set; }
        public int MW_Jahr { get; set; }
        public double MW_Wert { get; set; }
        public int MW_Status { get; set; }
        public Nullable<System.DateTime> MW_MutDate { get; set; }
        public string MW_MutUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_POM_Ref_MittelwertGruppe T_POM_Ref_MittelwertGruppe { get; set; }
    }
}

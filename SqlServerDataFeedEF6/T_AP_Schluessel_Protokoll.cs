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
    
    public partial class T_AP_Schluessel_Protokoll
    {
        public System.Guid SLP_UID { get; set; }
        public Nullable<System.Guid> SLP_SL_UID { get; set; }
        public System.DateTime SLP_Datum { get; set; }
        public string SLP_Aktion_DE { get; set; }
        public string SLP_Aktion_FR { get; set; }
        public string SLP_Aktion_EN { get; set; }
        public string SLP_Aktion_IT { get; set; }
        public string SLP_Bemerkung { get; set; }
        public int SLP_Status { get; set; }
    
        public virtual T_AP_Schluessel T_AP_Schluessel { get; set; }
    }
}

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
    
    public partial class T_AP_Gebaeude_Reichle
    {
        public System.Guid GB_UID { get; set; }
        public System.Guid GB_GB_UID { get; set; }
        public Nullable<System.Guid> GB_STR_UID { get; set; }
        public string GB_Hausnummer { get; set; }
        public string GB_Suffix { get; set; }
        public int GB_Status { get; set; }
    
        public virtual T_AP_Gebaeude T_AP_Gebaeude { get; set; }
        public virtual T_AP_Ref_Strasse_Reichle T_AP_Ref_Strasse_Reichle { get; set; }
    }
}

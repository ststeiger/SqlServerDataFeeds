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
    
    public partial class T_ZO_SYS_Metadatenrechte_Benutzergruppe
    {
        public System.Guid ZOMB_UID { get; set; }
        public System.Guid ZOMB_DMET_UID { get; set; }
        public int ZOMB_BG_ID { get; set; }
        public bool ZOMB_Right { get; set; }
    
        public virtual T_AP_Ref_DokumentMetadaten T_AP_Ref_DokumentMetadaten { get; set; }
        public virtual T_Benutzergruppen T_Benutzergruppen { get; set; }
    }
}

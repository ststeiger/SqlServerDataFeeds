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
    
    public partial class T_ZO_MM_Bestand_Umzug
    {
        public System.Guid ZO_BUMM_UID { get; set; }
        public Nullable<System.Guid> ZO_BUMM_MMU_UID { get; set; }
        public Nullable<System.Guid> ZO_BUMM_MMUB_UID { get; set; }
        public int ZO_BUMM_Status { get; set; }
        public bool ZO_BUMM_IsMove { get; set; }
        public bool ZO_BUMM_IsDismantle { get; set; }
        public bool ZO_BUMM_IsNew { get; set; }
        public bool ZO_BUMM_IsWrong { get; set; }
        public string ZO_BUMM_B_Kategorie { get; set; }
        public string ZO_BUMM_B_Name { get; set; }
        public string ZO_BUMM_B_SerienNummer { get; set; }
        public string ZO_BUMM_B_Hersteller { get; set; }
        public bool ZO_BUMM_IsDontMove { get; set; }
        public int ZO_BUMM_Tabelle { get; set; }
        public Nullable<System.Guid> ZO_BUMM_OBJ_UID { get; set; }
    
        public virtual T_MM_Umzug T_MM_Umzug { get; set; }
        public virtual T_MM_Umzug_Bestand T_MM_Umzug_Bestand { get; set; }
    }
}

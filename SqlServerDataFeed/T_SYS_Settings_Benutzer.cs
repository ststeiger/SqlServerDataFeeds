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
    
    public partial class T_SYS_Settings_Benutzer
    {
        public T_SYS_Settings_Benutzer()
        {
            this.T_ZO_SYS_Settings_Benutzer = new HashSet<T_ZO_SYS_Settings_Benutzer>();
        }
    
        public System.Guid SET_UID { get; set; }
        public string SET_Modul { get; set; }
        public string SET_Code { get; set; }
        public string SET_Typ { get; set; }
        public bool SET_IsMultiSelect { get; set; }
        public string SET_SourceTable { get; set; }
        public string SET_SourcePrfx { get; set; }
        public string SET_Bezeichnung { get; set; }
        public short SET_Status { get; set; }
        public int SET_Sort { get; set; }
        public string SET_Bemerkung { get; set; }
    
        public virtual ICollection<T_ZO_SYS_Settings_Benutzer> T_ZO_SYS_Settings_Benutzer { get; set; }
    }
}
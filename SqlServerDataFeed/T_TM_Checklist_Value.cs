//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SqlServerDataFeed
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_TM_Checklist_Value
    {
        public System.Guid TCLV_UID { get; set; }
        public System.Guid TCLD_UID { get; set; }
        public System.Guid TSK_UID { get; set; }
        public string Value { get; set; }
        public Nullable<long> isChecked { get; set; }
        public System.DateTime dateCreated { get; set; }
        public int TCLV_Status { get; set; }
    }
}

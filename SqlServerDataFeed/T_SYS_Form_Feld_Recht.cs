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
    
    public partial class T_SYS_Form_Feld_Recht
    {
        public System.Guid FFR_UID { get; set; }
        public int FFR_GRANTEE_ID { get; set; }
        public Nullable<System.Guid> FFR_OBJT_UID { get; set; }
        public Nullable<System.Guid> FFR_LANG_UID { get; set; }
        public bool FFR_IsRead { get; set; }
        public bool FFR_IsWrite { get; set; }
        public bool FFR_IsInsert { get; set; }
        public bool FFR_IsDelete { get; set; }
        public int FFR_Status { get; set; }
        public int FFR_MDT_ID { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_OV_Ref_ObjektTyp T_OV_Ref_ObjektTyp { get; set; }
    }
}

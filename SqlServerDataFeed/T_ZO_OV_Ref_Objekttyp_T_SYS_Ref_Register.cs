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
    
    public partial class T_ZO_OV_Ref_Objekttyp_T_SYS_Ref_Register
    {
        public System.Guid ZO_OBJTREG_UID { get; set; }
        public int ZO_OBJTREG_Status { get; set; }
    
        public virtual T_OV_Ref_ObjektTyp T_OV_Ref_ObjektTyp { get; set; }
        public virtual T_SYS_Ref_Register T_SYS_Ref_Register { get; set; }
    }
}

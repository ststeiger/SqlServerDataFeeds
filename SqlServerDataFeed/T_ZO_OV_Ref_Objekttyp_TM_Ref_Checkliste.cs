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
    
    public partial class T_ZO_OV_Ref_Objekttyp_TM_Ref_Checkliste
    {
        public System.Guid ZO_OBJTCL_UID { get; set; }
        public Nullable<System.Guid> ZO_OBJTCL_OBJT_UID { get; set; }
        public System.Guid ZO_OBJTCL_TCL_UID { get; set; }
        public int ZO_OBJTCL_Status { get; set; }
    
        public virtual T_OV_Ref_ObjektTyp T_OV_Ref_ObjektTyp { get; set; }
        public virtual T_TM_Ref_Checkliste T_TM_Ref_Checkliste { get; set; }
    }
}

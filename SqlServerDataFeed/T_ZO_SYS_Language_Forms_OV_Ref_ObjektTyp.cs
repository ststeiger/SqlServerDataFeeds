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
    
    public partial class T_ZO_SYS_Language_Forms_OV_Ref_ObjektTyp
    {
        public System.Guid ZO_LANGOBJT_UID { get; set; }
        public Nullable<System.Guid> ZO_LANGOBJT_LANG_UID { get; set; }
        public Nullable<System.Guid> ZO_LANGOBJT_OBJT_UID { get; set; }
        public int ZO_LANGOBJT_Sort { get; set; }
        public string ZO_LANGOBJT_LANG_Object { get; set; }
        public string ZO_LANGOBJT_LANG_Register { get; set; }
        public int ZO_LANGOBJT_Status { get; set; }
    
        public virtual T_OV_Ref_ObjektTyp T_OV_Ref_ObjektTyp { get; set; }
    }
}
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
    
    public partial class T_FMS_ZO_Filter_Dependency
    {
        public System.Guid FD_UID { get; set; }
        public System.Guid FD_FI_UID_Parent { get; set; }
        public System.Guid FD_FI_UID_Child { get; set; }
        public Nullable<int> FD_Sort { get; set; }
    
        public virtual T_FMS_ZO_Filter T_FMS_ZO_Filter { get; set; }
        public virtual T_FMS_ZO_Filter T_FMS_ZO_Filter1 { get; set; }
    }
}
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
    
    public partial class T_SYS_Ref_Version
    {
        public System.Guid VER_UID { get; set; }
        public int VER_MDT_ID { get; set; }
        public int VER_BE_ID { get; set; }
        public string VER_Label { get; set; }
        public System.DateTime VER_Date { get; set; }
        public int VER_Status { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_Benutzer T_Benutzer { get; set; }
    }
}

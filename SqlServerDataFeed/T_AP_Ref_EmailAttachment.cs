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
    
    public partial class T_AP_Ref_EmailAttachment
    {
        public System.Guid EA_UID { get; set; }
        public System.Guid EA_EMAIL_UID { get; set; }
        public byte[] EA_File { get; set; }
        public string EA_DateiEndung { get; set; }
        public string EA_DateiTyp { get; set; }
        public bool EA_Status { get; set; }
    
        public virtual T_AP_EmailVersand T_AP_EmailVersand { get; set; }
    }
}

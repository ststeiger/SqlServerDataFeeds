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
    
    public partial class T_Benutzer_Benutzergruppen
    {
        public System.Guid BEBG_ID { get; set; }
        public Nullable<int> BEBG_BE { get; set; }
        public Nullable<int> BEBG_BG { get; set; }
    
        public virtual T_Benutzer T_Benutzer { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SqlServerDataFeedEF6
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Document
    {
        public int Index { get; set; }
        public int BE_ID { get; set; }
        public Nullable<System.Guid> Reference { get; set; }
        public byte[] Document { get; set; }
        public string Mime { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public System.DateTime Created { get; set; }
        public int DOC_Status { get; set; }
    }
}
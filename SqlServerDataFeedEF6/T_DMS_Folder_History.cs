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
    
    public partial class T_DMS_Folder_History
    {
        public System.Guid HIFO_UID { get; set; }
        public System.Guid HIFO_FO_UID { get; set; }
        public System.DateTime HIFO_Datum { get; set; }
        public string HIFO_User { get; set; }
        public string HIFO_Text_DE { get; set; }
        public string HIFO_Text_FR { get; set; }
        public string HIFO_Text_IT { get; set; }
        public string HIFO_Text_EN { get; set; }
        public bool HIFO_IsNew { get; set; }
        public bool HIFO_IsChange { get; set; }
        public int HIFO_Status { get; set; }
    
        public virtual T_DMS_Folder T_DMS_Folder { get; set; }
    }
}

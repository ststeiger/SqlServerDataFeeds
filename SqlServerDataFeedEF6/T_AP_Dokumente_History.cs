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
    
    public partial class T_AP_Dokumente_History
    {
        public System.Guid HIDK_UID { get; set; }
        public System.Guid HIDK_DK_UID { get; set; }
        public System.Guid HIDK_Entry_UID { get; set; }
        public System.DateTime HIDK_Datum { get; set; }
        public string HIDK_User { get; set; }
        public string HIDK_Feldname { get; set; }
        public string HIDK_Feld_DE { get; set; }
        public string HIDK_Feld_FR { get; set; }
        public string HIDK_Feld_IT { get; set; }
        public string HIDK_Feld_EN { get; set; }
        public string HIDK_Alt_DE { get; set; }
        public string HIDK_Alt_FR { get; set; }
        public string HIDK_Alt_IT { get; set; }
        public string HIDK_Alt_EN { get; set; }
        public string HIDK_Neu_DE { get; set; }
        public string HIDK_Neu_FR { get; set; }
        public string HIDK_Neu_IT { get; set; }
        public string HIDK_Neu_EN { get; set; }
    
        public virtual T_AP_Dokumente T_AP_Dokumente { get; set; }
    }
}

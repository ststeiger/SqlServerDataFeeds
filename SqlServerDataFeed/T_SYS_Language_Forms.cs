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
    
    public partial class T_SYS_Language_Forms
    {
        public T_SYS_Language_Forms()
        {
            this.T_ZO_SYS_Language_Forms = new HashSet<T_ZO_SYS_Language_Forms>();
        }
    
        public System.Guid LANG_UID { get; set; }
        public string LANG_Modul { get; set; }
        public string LANG_Object { get; set; }
        public string LANG_Register { get; set; }
        public Nullable<int> LANG_Position { get; set; }
        public string LANG_DE { get; set; }
        public string LANG_FR { get; set; }
        public string LANG_EN { get; set; }
        public string LANG_IT { get; set; }
        public string LANG_Fieldname { get; set; }
        public string LANG_FieldType { get; set; }
        public bool LANG_IsRequired { get; set; }
        public string LANG_Validate { get; set; }
        public string LANG_Reftable { get; set; }
        public bool LANG_CheckHistory { get; set; }
        public bool LANG_IsValidity { get; set; }
        public Nullable<System.DateTime> LANG_ErfDate { get; set; }
        public int LANG_Status { get; set; }
    
        public virtual ICollection<T_ZO_SYS_Language_Forms> T_ZO_SYS_Language_Forms { get; set; }
    }
}

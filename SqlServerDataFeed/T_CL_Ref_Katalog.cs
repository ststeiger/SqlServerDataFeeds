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
    
    public partial class T_CL_Ref_Katalog
    {
        public T_CL_Ref_Katalog()
        {
            this.T_CL_ZO_DropDown = new HashSet<T_CL_ZO_DropDown>();
            this.T_CL_ZO_DropDown1 = new HashSet<T_CL_ZO_DropDown>();
        }
    
        public System.Guid CLKA_UID { get; set; }
        public Nullable<System.Guid> CLKA_CLKA_UID { get; set; }
        public int CLKA_MDT_ID { get; set; }
        public Nullable<int> CLKA_Code { get; set; }
        public string CLKA_Kurz_DE { get; set; }
        public string CLKA_Kurz_FR { get; set; }
        public string CLKA_Kurz_IT { get; set; }
        public string CLKA_Kurz_EN { get; set; }
        public string CLKA_Lang_DE { get; set; }
        public string CLKA_Lang_FR { get; set; }
        public string CLKA_Lang_IT { get; set; }
        public string CLKA_Lang_EN { get; set; }
        public int CLKA_Status { get; set; }
        public int CLKA_Sort { get; set; }
        public Nullable<int> CLKA_StylizerFore { get; set; }
        public Nullable<int> CLKA_StylizerBack { get; set; }
        public Nullable<int> CLKA_StylizerPattern { get; set; }
        public Nullable<int> CLKA_StylizerLine { get; set; }
        public bool CLKA_IsDefault { get; set; }
        public Nullable<System.DateTime> CLKA_DatumMut { get; set; }
        public string CLKA_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual ICollection<T_CL_ZO_DropDown> T_CL_ZO_DropDown { get; set; }
        public virtual ICollection<T_CL_ZO_DropDown> T_CL_ZO_DropDown1 { get; set; }
    }
}
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
    
    public partial class T_SYS_Berechtigung_Felder
    {
        public int BF_ID { get; set; }
        public int BF_BT_ID { get; set; }
        public string BF_Feldname { get; set; }
        public string BF_Feldbezeichnung { get; set; }
        public string BF_Registerbezeichnung { get; set; }
        public int BF_Sort_Register { get; set; }
        public int BF_Sort { get; set; }
        public bool BF_IsOnlyShow { get; set; }
        public bool BF_IsCalc { get; set; }
        public Nullable<System.DateTime> BF_ErfDate { get; set; }
        public int BF_Status { get; set; }
        public string BF_OBJT_Code { get; set; }
        public string BF_Kunde { get; set; }
    }
}

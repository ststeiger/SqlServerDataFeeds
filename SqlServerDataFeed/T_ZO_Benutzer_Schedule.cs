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
    
    public partial class T_ZO_Benutzer_Schedule
    {
        public int ZOBE_BE_ID { get; set; }
        public int ZOBE_Day_Start { get; set; }
        public int ZOBE_Day_End { get; set; }
        public int ZOBE_Week_Start { get; set; }
        public int ZOBE_Week_End { get; set; }
    
        public virtual T_Benutzer T_Benutzer { get; set; }
    }
}

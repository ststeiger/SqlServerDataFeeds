//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
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

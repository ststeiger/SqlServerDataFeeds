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
    
    public partial class T_ZO_AP_Aussenobjekt_AP_Ref_AussenobjektAusbauten
    {
        public System.Guid ZO_AOABT_UID { get; set; }
        public int ZO_AOABT_Menge { get; set; }
        public int ZO_AOABT_Status { get; set; }
    
        public virtual T_AP_Aussenobjekt T_AP_Aussenobjekt { get; set; }
        public virtual T_AP_Ref_AussenobjektAusbauten T_AP_Ref_AussenobjektAusbauten { get; set; }
    }
}

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
    
    public partial class T_ZO_AP_Ref_Arbeitsplatzkategorie_AP_Ref_MobiliarBibliothek
    {
        public System.Guid ZO_APKMB_UID { get; set; }
        public Nullable<System.Guid> ZO_APKMB_APK_UID { get; set; }
        public Nullable<System.Guid> ZO_APKMB_MB_UID { get; set; }
        public Nullable<System.Guid> ZO_APKMB_MF_UID { get; set; }
        public int ZO_APKMB_Anzahl { get; set; }
        public int ZO_APKMB_Status { get; set; }
    
        public virtual T_AP_Ref_ArbeitsplatzKategorie T_AP_Ref_ArbeitsplatzKategorie { get; set; }
    }
}

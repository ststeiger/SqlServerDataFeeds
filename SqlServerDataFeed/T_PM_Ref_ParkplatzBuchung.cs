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
    
    public partial class T_PM_Ref_ParkplatzBuchung
    {
        public System.Guid PB_UID { get; set; }
        public int PB_MDT_ID { get; set; }
        public Nullable<int> PB_Code { get; set; }
        public string PB_Kurz_DE { get; set; }
        public string PB_Kurz_FR { get; set; }
        public string PB_Kurz_IT { get; set; }
        public string PB_Kurz_EN { get; set; }
        public string PB_Lang_DE { get; set; }
        public string PB_Lang_FR { get; set; }
        public string PB_Lang_IT { get; set; }
        public string PB_Lang_EN { get; set; }
        public int PB_Status { get; set; }
        public int PB_Sort { get; set; }
        public Nullable<int> PB_StylizerFore { get; set; }
        public Nullable<int> PB_StylizerBack { get; set; }
        public Nullable<int> PB_StylizerPattern { get; set; }
        public Nullable<int> PB_StylizerLine { get; set; }
        public bool PB_IsDefault { get; set; }
        public Nullable<System.DateTime> PB_DatumMut { get; set; }
        public string PB_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
    }
}

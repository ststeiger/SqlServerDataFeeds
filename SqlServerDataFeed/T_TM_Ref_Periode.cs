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
    
    public partial class T_TM_Ref_Periode
    {
        public System.Guid PER_UID { get; set; }
        public int PER_MDT_ID { get; set; }
        public Nullable<int> PER_Code { get; set; }
        public string PER_Kurz_DE { get; set; }
        public string PER_Kurz_FR { get; set; }
        public string PER_Kurz_IT { get; set; }
        public string PER_Kurz_EN { get; set; }
        public string PER_Lang_DE { get; set; }
        public string PER_Lang_FR { get; set; }
        public string PER_Lang_IT { get; set; }
        public string PER_Lang_EN { get; set; }
        public int PER_Status { get; set; }
        public int PER_Sort { get; set; }
        public Nullable<int> PER_StylizerFore { get; set; }
        public Nullable<int> PER_StylizerBack { get; set; }
        public Nullable<int> PER_StylizerPattern { get; set; }
        public Nullable<int> PER_StylizerLine { get; set; }
        public bool PER_IsDefault { get; set; }
        public Nullable<System.DateTime> PER_DatumMut { get; set; }
        public string PER_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
    }
}

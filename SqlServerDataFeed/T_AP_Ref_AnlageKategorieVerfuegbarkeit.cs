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
    
    public partial class T_AP_Ref_AnlageKategorieVerfuegbarkeit
    {
        public T_AP_Ref_AnlageKategorieVerfuegbarkeit()
        {
            this.T_AP_Anlage = new HashSet<T_AP_Anlage>();
        }
    
        public System.Guid AKV_UID { get; set; }
        public int AKV_MDT_ID { get; set; }
        public Nullable<int> AKV_Code { get; set; }
        public string AKV_Kurz_DE { get; set; }
        public string AKV_Kurz_FR { get; set; }
        public string AKV_Kurz_IT { get; set; }
        public string AKV_Kurz_EN { get; set; }
        public string AKV_Lang_DE { get; set; }
        public string AKV_Lang_FR { get; set; }
        public string AKV_Lang_IT { get; set; }
        public string AKV_Lang_EN { get; set; }
        public int AKV_Status { get; set; }
        public int AKV_Sort { get; set; }
        public Nullable<int> AKV_StylizerFore { get; set; }
        public Nullable<int> AKV_StylizerBack { get; set; }
        public Nullable<int> AKV_StylizerPattern { get; set; }
        public Nullable<int> AKV_StylizerLine { get; set; }
        public bool AKV_IsDefault { get; set; }
        public Nullable<System.DateTime> AKV_DatumMut { get; set; }
        public string AKV_DatumUser { get; set; }
    
        public virtual ICollection<T_AP_Anlage> T_AP_Anlage { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
    }
}

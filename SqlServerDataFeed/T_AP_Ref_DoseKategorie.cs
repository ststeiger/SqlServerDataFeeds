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
    
    public partial class T_AP_Ref_DoseKategorie
    {
        public T_AP_Ref_DoseKategorie()
        {
            this.T_AP_Dose = new HashSet<T_AP_Dose>();
        }
    
        public System.Guid DKAT_UID { get; set; }
        public int DKAT_MDT_ID { get; set; }
        public Nullable<int> DKAT_Code { get; set; }
        public string DKAT_Kurz_DE { get; set; }
        public string DKAT_Kurz_FR { get; set; }
        public string DKAT_Kurz_IT { get; set; }
        public string DKAT_Kurz_EN { get; set; }
        public string DKAT_Lang_DE { get; set; }
        public string DKAT_Lang_FR { get; set; }
        public string DKAT_Lang_IT { get; set; }
        public string DKAT_Lang_EN { get; set; }
        public int DKAT_Status { get; set; }
        public int DKAT_Sort { get; set; }
        public Nullable<int> DKAT_StylizerFore { get; set; }
        public Nullable<int> DKAT_StylizerBack { get; set; }
        public Nullable<int> DKAT_StylizerPattern { get; set; }
        public Nullable<int> DKAT_StylizerLine { get; set; }
        public bool DKAT_IsDefault { get; set; }
        public Nullable<System.DateTime> DKAT_DatumMut { get; set; }
        public string DKAT_DatumUser { get; set; }
    
        public virtual ICollection<T_AP_Dose> T_AP_Dose { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
    }
}

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
    
    public partial class T_AP_Ref_InformatikKategorie
    {
        public T_AP_Ref_InformatikKategorie()
        {
            this.T_AP_Informatik = new HashSet<T_AP_Informatik>();
        }
    
        public System.Guid IKAT_UID { get; set; }
        public Nullable<int> IKAT_Code { get; set; }
        public string IKAT_Kurz_DE { get; set; }
        public string IKAT_Kurz_FR { get; set; }
        public string IKAT_Kurz_IT { get; set; }
        public string IKAT_Kurz_EN { get; set; }
        public string IKAT_Lang_DE { get; set; }
        public string IKAT_Lang_FR { get; set; }
        public string IKAT_Lang_IT { get; set; }
        public string IKAT_Lang_EN { get; set; }
        public int IKAT_Status { get; set; }
        public int IKAT_Sort { get; set; }
        public Nullable<int> IKAT_StylizerBack { get; set; }
        public Nullable<int> IKAT_StylizerPattern { get; set; }
        public Nullable<int> IKAT_StylizerLine { get; set; }
        public bool IKAT_IsDefault { get; set; }
        public Nullable<System.DateTime> IKAT_DatumMut { get; set; }
        public string IKAT_DatumUser { get; set; }
        public Nullable<bool> IKAT_canBook { get; set; }
    
        public virtual ICollection<T_AP_Informatik> T_AP_Informatik { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

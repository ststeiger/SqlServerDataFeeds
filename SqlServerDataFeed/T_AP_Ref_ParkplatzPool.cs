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
    
    public partial class T_AP_Ref_ParkplatzPool
    {
        public T_AP_Ref_ParkplatzPool()
        {
            this.T_ZO_AP_Parkplatz_AP_Belegung = new HashSet<T_ZO_AP_Parkplatz_AP_Belegung>();
        }
    
        public System.Guid PPO_UID { get; set; }
        public Nullable<int> PPO_Code { get; set; }
        public string PPO_Kurz_DE { get; set; }
        public string PPO_Kurz_FR { get; set; }
        public string PPO_Kurz_IT { get; set; }
        public string PPO_Kurz_EN { get; set; }
        public string PPO_Lang_DE { get; set; }
        public string PPO_Lang_FR { get; set; }
        public string PPO_Lang_IT { get; set; }
        public string PPO_Lang_EN { get; set; }
        public int PPO_Status { get; set; }
        public int PPO_Sort { get; set; }
        public Nullable<int> PPO_StylizerBack { get; set; }
        public Nullable<int> PPO_StylizerPattern { get; set; }
        public Nullable<int> PPO_StylizerLine { get; set; }
        public bool PPO_IsDefault { get; set; }
        public Nullable<System.DateTime> PPO_DatumMut { get; set; }
        public string PPO_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        public virtual ICollection<T_ZO_AP_Parkplatz_AP_Belegung> T_ZO_AP_Parkplatz_AP_Belegung { get; set; }
    }
}

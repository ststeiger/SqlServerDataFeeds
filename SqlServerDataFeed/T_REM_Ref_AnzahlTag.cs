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
    
    public partial class T_REM_Ref_AnzahlTag
    {
        public T_REM_Ref_AnzahlTag()
        {
            this.T_REM_Ref_Vorlagen = new HashSet<T_REM_Ref_Vorlagen>();
            this.T_ZO_REM_AP_Raum_Reinigung_Kalk = new HashSet<T_ZO_REM_AP_Raum_Reinigung_Kalk>();
            this.T_ZO_REM_AP_Raum_Reinigung = new HashSet<T_ZO_REM_AP_Raum_Reinigung>();
        }
    
        public System.Guid REMAT_UID { get; set; }
        public Nullable<int> REMAT_Code { get; set; }
        public string REMAT_Kurz_de { get; set; }
        public string REMAT_Kurz_fr { get; set; }
        public string REMAT_Kurz_it { get; set; }
        public string REMAT_Kurz_en { get; set; }
        public string REMAT_Lang_de { get; set; }
        public string REMAT_Lang_fr { get; set; }
        public string REMAT_Lang_it { get; set; }
        public string REMAT_Lang_en { get; set; }
        public int REMAT_Status { get; set; }
        public int REMAT_Sort { get; set; }
        public bool REMAT_IsDefault { get; set; }
        public Nullable<int> REMAT_StylizerFore { get; set; }
        public Nullable<int> REMAT_StylizerPattern { get; set; }
        public Nullable<int> REMAT_StylizerLine { get; set; }
    
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        public virtual ICollection<T_REM_Ref_Vorlagen> T_REM_Ref_Vorlagen { get; set; }
        public virtual ICollection<T_ZO_REM_AP_Raum_Reinigung_Kalk> T_ZO_REM_AP_Raum_Reinigung_Kalk { get; set; }
        public virtual ICollection<T_ZO_REM_AP_Raum_Reinigung> T_ZO_REM_AP_Raum_Reinigung { get; set; }
    }
}

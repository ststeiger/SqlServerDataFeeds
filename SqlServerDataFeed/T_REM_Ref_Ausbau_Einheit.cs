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
    
    public partial class T_REM_Ref_Ausbau_Einheit
    {
        public T_REM_Ref_Ausbau_Einheit()
        {
            this.T_REM_Ref_Ausbau = new HashSet<T_REM_Ref_Ausbau>();
        }
    
        public System.Guid REMAE_UID { get; set; }
        public Nullable<int> REMAE_Code { get; set; }
        public string REMAE_Kurz_de { get; set; }
        public string REMAE_Kurz_fr { get; set; }
        public string REMAE_Kurz_it { get; set; }
        public string REMAE_Kurz_en { get; set; }
        public string REMAE_Lang_de { get; set; }
        public string REMAE_Lang_fr { get; set; }
        public string REMAE_Lang_it { get; set; }
        public string REMAE_Lang_en { get; set; }
        public int REMAE_Status { get; set; }
        public int REMAE_Sort { get; set; }
        public bool REMAE_IsDefault { get; set; }
        public Nullable<int> REMAE_StylizerFore { get; set; }
        public Nullable<int> REMAE_StylizerPattern { get; set; }
        public Nullable<int> REMAE_StylizerLine { get; set; }
    
        public virtual ICollection<T_REM_Ref_Ausbau> T_REM_Ref_Ausbau { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

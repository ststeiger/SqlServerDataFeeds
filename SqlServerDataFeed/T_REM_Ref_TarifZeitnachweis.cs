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
    
    public partial class T_REM_Ref_TarifZeitnachweis
    {
        public T_REM_Ref_TarifZeitnachweis()
        {
            this.T_REM_Ref_Arbeitsgang = new HashSet<T_REM_Ref_Arbeitsgang>();
        }
    
        public System.Guid REMTZ_UID { get; set; }
        public Nullable<int> REMTZ_Code { get; set; }
        public string REMTZ_Kurz_de { get; set; }
        public string REMTZ_Kurz_fr { get; set; }
        public string REMTZ_Kurz_it { get; set; }
        public string REMTZ_Kurz_en { get; set; }
        public string REMTZ_Lang_de { get; set; }
        public string REMTZ_Lang_fr { get; set; }
        public string REMTZ_Lang_it { get; set; }
        public string REMTZ_Lang_en { get; set; }
        public int REMTZ_Status { get; set; }
        public int REMTZ_Sort { get; set; }
        public bool REMTZ_IsDefault { get; set; }
        public Nullable<int> REMTZ_StylizerFore { get; set; }
        public Nullable<int> REMTZ_StylizerPattern { get; set; }
        public Nullable<int> REMTZ_StylizerLine { get; set; }
    
        public virtual ICollection<T_REM_Ref_Arbeitsgang> T_REM_Ref_Arbeitsgang { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

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
    
    public partial class T_REM_Ref_Reinigungsart
    {
        public T_REM_Ref_Reinigungsart()
        {
            this.T_REM_Ref_Arbeitsgang = new HashSet<T_REM_Ref_Arbeitsgang>();
            this.T_REM_Ref_Vorlagen = new HashSet<T_REM_Ref_Vorlagen>();
            this.T_ZO_REM_AP_Raum_Ref_Reinigungsart_Kalk = new HashSet<T_ZO_REM_AP_Raum_Ref_Reinigungsart_Kalk>();
            this.T_ZO_REM_AP_Raum_Ref_Reinigungsart = new HashSet<T_ZO_REM_AP_Raum_Ref_Reinigungsart>();
        }
    
        public System.Guid REMRA_UID { get; set; }
        public Nullable<int> REMRA_Code { get; set; }
        public string REMRA_Kurz_de { get; set; }
        public string REMRA_Kurz_fr { get; set; }
        public string REMRA_Kurz_it { get; set; }
        public string REMRA_Kurz_en { get; set; }
        public string REMRA_Lang_de { get; set; }
        public string REMRA_Lang_fr { get; set; }
        public string REMRA_Lang_it { get; set; }
        public string REMRA_Lang_en { get; set; }
        public int REMRA_Status { get; set; }
        public int REMRA_Sort { get; set; }
        public bool REMRA_IsDefault { get; set; }
        public Nullable<int> REMRA_StylizerBack { get; set; }
        public Nullable<int> REMRA_StylizerFore { get; set; }
        public Nullable<int> REMRA_StylizerPattern { get; set; }
        public Nullable<int> REMRA_StylizerLine { get; set; }
        public int REMRA_MDT_ID { get; set; }
    
        public virtual ICollection<T_REM_Ref_Arbeitsgang> T_REM_Ref_Arbeitsgang { get; set; }
        public virtual ICollection<T_REM_Ref_Vorlagen> T_REM_Ref_Vorlagen { get; set; }
        public virtual ICollection<T_ZO_REM_AP_Raum_Ref_Reinigungsart_Kalk> T_ZO_REM_AP_Raum_Ref_Reinigungsart_Kalk { get; set; }
        public virtual ICollection<T_ZO_REM_AP_Raum_Ref_Reinigungsart> T_ZO_REM_AP_Raum_Ref_Reinigungsart { get; set; }
    }
}

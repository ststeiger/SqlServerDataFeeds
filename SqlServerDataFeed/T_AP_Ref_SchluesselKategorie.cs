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
    
    public partial class T_AP_Ref_SchluesselKategorie
    {
        public T_AP_Ref_SchluesselKategorie()
        {
            this.T_AP_Schluesselgruppe = new HashSet<T_AP_Schluesselgruppe>();
        }
    
        public System.Guid SKAT_UID { get; set; }
        public int SKAT_MDT_ID { get; set; }
        public Nullable<int> SKAT_Code { get; set; }
        public string SKAT_Kurz_DE { get; set; }
        public string SKAT_Kurz_FR { get; set; }
        public string SKAT_Kurz_IT { get; set; }
        public string SKAT_Kurz_EN { get; set; }
        public string SKAT_Lang_DE { get; set; }
        public string SKAT_Lang_FR { get; set; }
        public string SKAT_Lang_IT { get; set; }
        public string SKAT_Lang_EN { get; set; }
        public int SKAT_Status { get; set; }
        public int SKAT_Sort { get; set; }
        public Nullable<int> SKAT_StylizerFore { get; set; }
        public Nullable<int> SKAT_StylizerBack { get; set; }
        public Nullable<int> SKAT_StylizerPattern { get; set; }
        public Nullable<int> SKAT_StylizerLine { get; set; }
        public bool SKAT_IsDefault { get; set; }
        public Nullable<System.DateTime> SKAT_DatumMut { get; set; }
        public string SKAT_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual ICollection<T_AP_Schluesselgruppe> T_AP_Schluesselgruppe { get; set; }
    }
}

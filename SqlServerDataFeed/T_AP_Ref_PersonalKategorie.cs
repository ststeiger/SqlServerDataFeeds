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
    
    public partial class T_AP_Ref_PersonalKategorie
    {
        public T_AP_Ref_PersonalKategorie()
        {
            this.T_AP_Kontakte = new HashSet<T_AP_Kontakte>();
            this.T_ZO_AP_Kontakte_AP_Ref_PersonalKategorie = new HashSet<T_ZO_AP_Kontakte_AP_Ref_PersonalKategorie>();
        }
    
        public System.Guid PK_UID { get; set; }
        public Nullable<int> PK_Code { get; set; }
        public string PK_Kurz_DE { get; set; }
        public string PK_Kurz_FR { get; set; }
        public string PK_Kurz_IT { get; set; }
        public string PK_Kurz_EN { get; set; }
        public string PK_Lang_DE { get; set; }
        public string PK_Lang_FR { get; set; }
        public string PK_Lang_IT { get; set; }
        public string PK_Lang_EN { get; set; }
        public int PK_Status { get; set; }
        public int PK_Sort { get; set; }
        public Nullable<int> PK_StylizerBack { get; set; }
        public Nullable<int> PK_StylizerPattern { get; set; }
        public Nullable<int> PK_StylizerLine { get; set; }
        public bool PK_IsDefault { get; set; }
        public Nullable<System.DateTime> PK_DatumMut { get; set; }
        public string PK_DatumUser { get; set; }
        public Nullable<bool> PK_IsFromOdis { get; set; }
    
        public virtual ICollection<T_AP_Kontakte> T_AP_Kontakte { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        public virtual ICollection<T_ZO_AP_Kontakte_AP_Ref_PersonalKategorie> T_ZO_AP_Kontakte_AP_Ref_PersonalKategorie { get; set; }
    }
}

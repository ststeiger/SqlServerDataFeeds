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
    
    public partial class T_AP_Ref_AnlageKategorie
    {
        public T_AP_Ref_AnlageKategorie()
        {
            this.T_AP_Anlage = new HashSet<T_AP_Anlage>();
            this.T_ZO_AP_Ref_AnlageKategorie_AP_Ref_AnlageKategorieSchema = new HashSet<T_ZO_AP_Ref_AnlageKategorie_AP_Ref_AnlageKategorieSchema>();
        }
    
        public System.Guid AK_UID { get; set; }
        public string AK_Code { get; set; }
        public string AK_Kurz_DE { get; set; }
        public string AK_Kurz_FR { get; set; }
        public string AK_Kurz_IT { get; set; }
        public string AK_Kurz_EN { get; set; }
        public string AK_Lang_DE { get; set; }
        public string AK_Lang_FR { get; set; }
        public string AK_Lang_IT { get; set; }
        public string AK_Lang_EN { get; set; }
        public int AK_Status { get; set; }
        public int AK_Sort { get; set; }
        public Nullable<int> AK_StylizerBack { get; set; }
        public Nullable<int> AK_StylizerPattern { get; set; }
        public Nullable<int> AK_StylizerLine { get; set; }
        public bool AK_IsDefault { get; set; }
        public Nullable<System.DateTime> AK_DatumMut { get; set; }
        public string AK_DatumUser { get; set; }
        public bool AK_HasDetail_1 { get; set; }
        public bool AK_HasDetail_2 { get; set; }
        public bool AK_HasDetail_3 { get; set; }
        public bool AK_HasDetail_4 { get; set; }
        public bool AK_HasDetail_5 { get; set; }
        public bool AK_HasDetail_6 { get; set; }
        public bool AK_HasDetail_7 { get; set; }
        public bool AK_HasDetail_8 { get; set; }
        public bool AK_HasDetail_9 { get; set; }
        public bool AK_HasDetail_10 { get; set; }
        public bool AK_HasDetail_11 { get; set; }
        public bool AK_HasDetail_12 { get; set; }
        public bool AK_HasDetail_13 { get; set; }
        public bool AK_HasDetail_14 { get; set; }
        public bool AK_HasDetail_15 { get; set; }
        public bool AK_HasDetail_16 { get; set; }
        public bool AK_HasDetail_17 { get; set; }
        public bool AK_HasDetail_18 { get; set; }
        public bool AK_HasDetail_19 { get; set; }
        public bool AK_HasDetail_20 { get; set; }
        public bool AK_HasDetail_21 { get; set; }
        public bool AK_HasDetail_22 { get; set; }
        public bool AK_HasDetail_23 { get; set; }
        public bool AK_HasDetail_24 { get; set; }
        public bool AK_HasDetail_25 { get; set; }
        public bool AK_HasDetail_26 { get; set; }
        public bool AK_HasDetail_27 { get; set; }
        public bool AK_HasDetail_28 { get; set; }
        public bool AK_HasDetail_29 { get; set; }
        public bool AK_HasDetail_30 { get; set; }
        public Nullable<System.Guid> AK_AK_UID { get; set; }
    
        public virtual ICollection<T_AP_Anlage> T_AP_Anlage { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        public virtual ICollection<T_ZO_AP_Ref_AnlageKategorie_AP_Ref_AnlageKategorieSchema> T_ZO_AP_Ref_AnlageKategorie_AP_Ref_AnlageKategorieSchema { get; set; }
    }
}

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
    
    public partial class T_AP_Ref_DokumentMetadaten
    {
        public T_AP_Ref_DokumentMetadaten()
        {
            this.T_AP_Ref_DokumentMetadaten1 = new HashSet<T_AP_Ref_DokumentMetadaten>();
            this.T_ZO_AP_Dokumente_AP_Ref_DokumentMetadaten = new HashSet<T_ZO_AP_Dokumente_AP_Ref_DokumentMetadaten>();
            this.T_ZO_SYS_Metadatenrechte_Benutzergruppe = new HashSet<T_ZO_SYS_Metadatenrechte_Benutzergruppe>();
        }
    
        public System.Guid DMET_UID { get; set; }
        public Nullable<int> DMET_Code { get; set; }
        public string DMET_Kurz_DE { get; set; }
        public string DMET_Kurz_FR { get; set; }
        public string DMET_Kurz_IT { get; set; }
        public string DMET_Kurz_EN { get; set; }
        public string DMET_Lang_DE { get; set; }
        public string DMET_Lang_FR { get; set; }
        public string DMET_Lang_IT { get; set; }
        public string DMET_Lang_EN { get; set; }
        public int DMET_Status { get; set; }
        public int DMET_Sort { get; set; }
        public Nullable<int> DMET_StylizerBack { get; set; }
        public Nullable<int> DMET_StylizerPattern { get; set; }
        public Nullable<int> DMET_StylizerLine { get; set; }
        public bool DMET_IsDefault { get; set; }
        public bool DMET_IsFreeText { get; set; }
        public Nullable<System.DateTime> DMET_DatumMut { get; set; }
        public string DMET_DatumUser { get; set; }
        public Nullable<bool> DMET_IsMandatory { get; set; }
        public Nullable<bool> DMET_MultiSelect { get; set; }
        public Nullable<int> DMET_Datalength { get; set; }
        public Nullable<bool> DMET_ShowInList { get; set; }
        public Nullable<bool> DMET_Permissionable { get; set; }
    
        public virtual ICollection<T_AP_Ref_DokumentMetadaten> T_AP_Ref_DokumentMetadaten1 { get; set; }
        public virtual T_AP_Ref_DokumentMetadaten T_AP_Ref_DokumentMetadaten2 { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        public virtual T_SYS_Ref_Datentyp T_SYS_Ref_Datentyp { get; set; }
        public virtual ICollection<T_ZO_AP_Dokumente_AP_Ref_DokumentMetadaten> T_ZO_AP_Dokumente_AP_Ref_DokumentMetadaten { get; set; }
        public virtual ICollection<T_ZO_SYS_Metadatenrechte_Benutzergruppe> T_ZO_SYS_Metadatenrechte_Benutzergruppe { get; set; }
    }
}

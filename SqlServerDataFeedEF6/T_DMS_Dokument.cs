//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SqlServerDataFeedEF6
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_DMS_Dokument
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_DMS_Dokument()
        {
            this.T_DMS_Dokument_History = new HashSet<T_DMS_Dokument_History>();
            this.T_DMS_Dokument_Version = new HashSet<T_DMS_Dokument_Version>();
            this.T_DMS_Navigation = new HashSet<T_DMS_Navigation>();
        }
    
        public System.Guid DOC_UID { get; set; }
        public Nullable<System.Guid> DOC_NT_UID { get; set; }
        public Nullable<System.Guid> DOC_DT_UID { get; set; }
        public Nullable<System.Guid> DOC_DG_UID { get; set; }
        public Nullable<System.Guid> DOC_DA_UID { get; set; }
        public Nullable<System.Guid> DOC_DS_UID { get; set; }
        public string DOC_ApertureKey { get; set; }
        public string DOC_Nr { get; set; }
        public string DOC_Bezeichnung { get; set; }
        public string DOC_Beschreibung { get; set; }
        public string DOC_Author { get; set; }
        public Nullable<System.DateTime> DOC_Ausgabedatum { get; set; }
        public string DOC_Dateiendung { get; set; }
        public string DOC_Meta_1 { get; set; }
        public string DOC_Meta_2 { get; set; }
        public string DOC_Meta_3 { get; set; }
        public string DOC_Meta_4 { get; set; }
        public string DOC_Meta_5 { get; set; }
        public string DOC_Meta_6 { get; set; }
        public string DOC_Meta_7 { get; set; }
        public string DOC_Meta_8 { get; set; }
        public string DOC_Meta_9 { get; set; }
        public string DOC_Meta_10 { get; set; }
        public string DOC_Bemerkung { get; set; }
        public System.DateTime DOC_DatumVon { get; set; }
        public System.DateTime DOC_DatumBis { get; set; }
        public int DOC_Status { get; set; }
        public Nullable<System.DateTime> DOC_MutDate { get; set; }
        public string DOC_MutUser { get; set; }
        public bool DOC_IsGesperrt { get; set; }
        public int DOC_GesperrtDurch { get; set; }
        public string DOC_AP_Projekt { get; set; }
        public string DOC_AP_Gebaeude { get; set; }
        public string DOC_AP_Geschoss { get; set; }
        public int DOC_ErstellerID { get; set; }
        public int DOC_ProjektleiterID { get; set; }
        public int DOC_AdminID { get; set; }
        public int DOC_VerantwortlichID { get; set; }
        public Nullable<System.DateTime> DOC_ProcessDeadline { get; set; }
        public Nullable<System.DateTime> DOC_ProcessDate { get; set; }
        public Nullable<System.Guid> DOC_PROC_UID { get; set; }
        public string DOC_NR_Backup { get; set; }
        public string DOC_Bezeichnung_Backup { get; set; }
        public Nullable<System.DateTime> DOC_ErsteFreigabe { get; set; }
        public Nullable<System.DateTime> DOC_LetzteFreigabe { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_DMS_Dokument_History> T_DMS_Dokument_History { get; set; }
        public virtual T_DMS_Ref_DokumentArt T_DMS_Ref_DokumentArt { get; set; }
        public virtual T_DMS_Ref_DokumentGruppe T_DMS_Ref_DokumentGruppe { get; set; }
        public virtual T_DMS_Ref_DokumentTyp T_DMS_Ref_DokumentTyp { get; set; }
        public virtual T_DMS_Ref_NodeType T_DMS_Ref_NodeType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_DMS_Dokument_Version> T_DMS_Dokument_Version { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_DMS_Navigation> T_DMS_Navigation { get; set; }
    }
}

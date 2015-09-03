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
    
    public partial class T_AP_Dokumente
    {
        public T_AP_Dokumente()
        {
            this.T_AP_Dokumente_History = new HashSet<T_AP_Dokumente_History>();
            this.T_AP_Dokumente_Log = new HashSet<T_AP_Dokumente_Log>();
            this.T_AP_Dokumente1 = new HashSet<T_AP_Dokumente>();
            this.T_ZO_AP_Dokumente_AP_Ref_DokumentMetadaten = new HashSet<T_ZO_AP_Dokumente_AP_Ref_DokumentMetadaten>();
            this.T_ZO_OV_Ref_ObjektSymbol = new HashSet<T_ZO_OV_Ref_ObjektSymbol>();
        }
    
        public System.Guid DK_UID { get; set; }
        public Nullable<System.Guid> DK_Objekt_UID { get; set; }
        public string DK_Bezeichnung { get; set; }
        public string DK_Datei { get; set; }
        public string DK_Dateiformat { get; set; }
        public int DK_Status { get; set; }
        public Nullable<bool> DK_IsDefault { get; set; }
        public byte[] DK_File { get; set; }
        public Nullable<System.DateTime> DK_Mut_Date { get; set; }
        public Nullable<bool> DK_Exportiert { get; set; }
        public string DK_ExportPfad { get; set; }
        public Nullable<int> DK_UniqueNum { get; set; }
        public string DK_UniqueNumText { get; set; }
        public Nullable<long> DK_Nr { get; set; }
        public Nullable<int> DK_Version { get; set; }
        public string DK_Kommentar { get; set; }
        public Nullable<System.DateTime> DK_EndDatum { get; set; }
        public Nullable<System.DateTime> DK_RueckgabeFrist { get; set; }
        public Nullable<bool> DK_Locked { get; set; }
        public Nullable<bool> DK_IsLink { get; set; }
        public Nullable<bool> DK_FileUploaded { get; set; }
    
        public virtual ICollection<T_AP_Dokumente_History> T_AP_Dokumente_History { get; set; }
        public virtual ICollection<T_AP_Dokumente_Log> T_AP_Dokumente_Log { get; set; }
        public virtual ICollection<T_AP_Dokumente> T_AP_Dokumente1 { get; set; }
        public virtual T_AP_Dokumente T_AP_Dokumente2 { get; set; }
        public virtual T_AP_Ref_DokumentKategorie T_AP_Ref_DokumentKategorie { get; set; }
        public virtual T_AP_Ref_DokumentStatus T_AP_Ref_DokumentStatus { get; set; }
        public virtual T_Benutzer T_Benutzer { get; set; }
        public virtual ICollection<T_ZO_AP_Dokumente_AP_Ref_DokumentMetadaten> T_ZO_AP_Dokumente_AP_Ref_DokumentMetadaten { get; set; }
        public virtual ICollection<T_ZO_OV_Ref_ObjektSymbol> T_ZO_OV_Ref_ObjektSymbol { get; set; }
    }
}

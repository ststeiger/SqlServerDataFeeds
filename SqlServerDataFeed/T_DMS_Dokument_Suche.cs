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
    
    public partial class T_DMS_Dokument_Suche
    {
        public System.Guid DOC_UID { get; set; }
        public int DOC_BE_ID { get; set; }
        public string DOC_SucheName { get; set; }
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
    }
}

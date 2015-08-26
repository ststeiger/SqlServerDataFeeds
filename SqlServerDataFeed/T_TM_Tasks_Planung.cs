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
    
    public partial class T_TM_Tasks_Planung
    {
        public T_TM_Tasks_Planung()
        {
            this.T_TM_Ref_Checkliste_Details = new HashSet<T_TM_Ref_Checkliste_Details>();
            this.T_TM_Ref_Checkliste_Taetigkeit = new HashSet<T_TM_Ref_Checkliste_Taetigkeit>();
            this.T_TM_Ref_Checkliste_Wartung = new HashSet<T_TM_Ref_Checkliste_Wartung>();
            this.T_TM_Tasks = new HashSet<T_TM_Tasks>();
            this.T_TM_Tasks_Planung_Checkpoints = new HashSet<T_TM_Tasks_Planung_Checkpoints>();
            this.T_ZO_TASK_Ref_Checkliste_Comment = new HashSet<T_ZO_TASK_Ref_Checkliste_Comment>();
        }
    
        public System.Guid TPL_UID { get; set; }
        public int TPL_MDT_ID { get; set; }
        public Nullable<System.Guid> TPL_OBJT_UID { get; set; }
        public Nullable<System.Guid> TPL_TART_UID { get; set; }
        public Nullable<System.Guid> TPL_ADR_UID_zustaendig { get; set; }
        public string TPL_Beschreibung { get; set; }
        public Nullable<System.DateTime> TPL_PlanungVon { get; set; }
        public Nullable<System.DateTime> TPL_PlanungBis { get; set; }
        public int TPL_Zyklus { get; set; }
        public Nullable<System.Guid> TPL_ZYP_UID { get; set; }
        public string TPL_Bemerkung { get; set; }
        public Nullable<System.DateTime> TPL_MutDate { get; set; }
        public string TPL_MutUser { get; set; }
        public int TPL_Status { get; set; }
        public Nullable<System.Guid> TPL_SO_UID { get; set; }
        public Nullable<System.Guid> TPL_GB_UID { get; set; }
        public Nullable<System.Guid> TPL_TK_UID { get; set; }
        public Nullable<System.Guid> TPL_GS_UID { get; set; }
        public Nullable<System.Guid> TPL_RM_UID { get; set; }
        public Nullable<System.Guid> TPL_TR_UID { get; set; }
        public Nullable<System.Guid> TPL_AL_UID { get; set; }
        public Nullable<System.Guid> TPL_KU_UID { get; set; }
        public Nullable<System.Guid> TPL_MO_UID { get; set; }
        public Nullable<System.Guid> TPL_PP_UID { get; set; }
        public Nullable<System.Guid> TPL_AP_UID { get; set; }
        public Nullable<System.Guid> TPL_SH_UID { get; set; }
        public Nullable<System.Guid> TPL_ADR_UID { get; set; }
        public Nullable<System.Guid> TPL_VTR_UID { get; set; }
        public Nullable<System.Guid> TPL_KT_UID { get; set; }
        public Nullable<int> TPL_BE_ID_erfasser { get; set; }
        public Nullable<int> TPL_BE_ID_verantwortlich { get; set; }
        public Nullable<System.Guid> TPL_DO_UID { get; set; }
        public Nullable<System.Guid> TPL_IN_UID { get; set; }
        public Nullable<System.Guid> TPL_KM_UID { get; set; }
        public Nullable<System.Guid> TPL_TCL_UID { get; set; }
        public Nullable<System.Guid> TPL_AO_UID { get; set; }
        public Nullable<System.Guid> TPL_ZYL_UID { get; set; }
        public Nullable<System.Guid> TPL_SLG_UID { get; set; }
        public int TPL_Vorwarnzeit { get; set; }
        public Nullable<System.Guid> TPL_ZYP_Vorwarnzeit_UID { get; set; }
        public bool TPL_IsPeriodisch { get; set; }
        public Nullable<System.Guid> TPL_PER_UID { get; set; }
        public int TPL_Dauer { get; set; }
        public Nullable<System.Guid> TPL_ZE_UID { get; set; }
        public Nullable<System.Guid> TPL_ZT_UID_Startzeit { get; set; }
        public int TPL_PER_Anzahl { get; set; }
        public string TPL_DefaultTag { get; set; }
        public string TPL_DefaultMonat { get; set; }
        public Nullable<System.Guid> TPL_BP_UID { get; set; }
        public Nullable<System.DateTime> TPL_Terminierung_Erstmals { get; set; }
        public int TPL_Terminierung_Zyklus { get; set; }
        public Nullable<System.Guid> TPL_Terminierung_ZYP_UID { get; set; }
        public Nullable<System.Guid> TPL_ZN_UID { get; set; }
        public Nullable<int> TPL_Sort { get; set; }
        public Nullable<System.Guid> TPL_ABT_UID { get; set; }
    
        public virtual T_AP_Anlage T_AP_Anlage { get; set; }
        public virtual T_AP_Arbeitsplatz T_AP_Arbeitsplatz { get; set; }
        public virtual T_AP_Aussenobjekt T_AP_Aussenobjekt { get; set; }
        public virtual T_AP_Dose T_AP_Dose { get; set; }
        public virtual T_AP_Gebaeude T_AP_Gebaeude { get; set; }
        public virtual T_AP_Geschoss T_AP_Geschoss { get; set; }
        public virtual T_AP_Informatik T_AP_Informatik { get; set; }
        public virtual T_AP_Kommunikation T_AP_Kommunikation { get; set; }
        public virtual T_AP_Kontakte T_AP_Kontakte { get; set; }
        public virtual T_AP_Kunst T_AP_Kunst { get; set; }
        public virtual T_AP_Mobiliar T_AP_Mobiliar { get; set; }
        public virtual T_AP_Parkplatz T_AP_Parkplatz { get; set; }
        public virtual T_AP_Raum T_AP_Raum { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_AP_Schluesselgruppe T_AP_Schluesselgruppe { get; set; }
        public virtual T_AP_Sicherheit T_AP_Sicherheit { get; set; }
        public virtual T_AP_Standort T_AP_Standort { get; set; }
        public virtual T_AP_Trakt T_AP_Trakt { get; set; }
        public virtual T_AP_Tuer T_AP_Tuer { get; set; }
        public virtual T_AP_Zone T_AP_Zone { get; set; }
        public virtual T_AP_Zylinder T_AP_Zylinder { get; set; }
        public virtual T_AV_Adressen T_AV_Adressen { get; set; }
        public virtual T_AV_Adressen T_AV_Adressen1 { get; set; }
        public virtual T_Benutzer T_Benutzer { get; set; }
        public virtual T_Benutzer T_Benutzer1 { get; set; }
        public virtual T_OV_Ref_ObjektTyp T_OV_Ref_ObjektTyp { get; set; }
        public virtual T_TM_Ref_Abteilung T_TM_Ref_Abteilung { get; set; }
        public virtual T_TM_Ref_Checkliste T_TM_Ref_Checkliste { get; set; }
        public virtual ICollection<T_TM_Ref_Checkliste_Details> T_TM_Ref_Checkliste_Details { get; set; }
        public virtual ICollection<T_TM_Ref_Checkliste_Taetigkeit> T_TM_Ref_Checkliste_Taetigkeit { get; set; }
        public virtual ICollection<T_TM_Ref_Checkliste_Wartung> T_TM_Ref_Checkliste_Wartung { get; set; }
        public virtual T_TM_Ref_TaskArt T_TM_Ref_TaskArt { get; set; }
        public virtual T_TM_Ref_ZyklusPeriode T_TM_Ref_ZyklusPeriode { get; set; }
        public virtual T_TM_Ref_ZyklusPeriode T_TM_Ref_ZyklusPeriode1 { get; set; }
        public virtual ICollection<T_TM_Tasks> T_TM_Tasks { get; set; }
        public virtual ICollection<T_TM_Tasks_Planung_Checkpoints> T_TM_Tasks_Planung_Checkpoints { get; set; }
        public virtual T_VM_Vertraege T_VM_Vertraege { get; set; }
        public virtual ICollection<T_ZO_TASK_Ref_Checkliste_Comment> T_ZO_TASK_Ref_Checkliste_Comment { get; set; }
    }
}

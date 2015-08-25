//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SqlServerDataFeed
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_AP_Informatik
    {
        public T_AP_Informatik()
        {
            this.T_AP_Informatik_History = new HashSet<T_AP_Informatik_History>();
            this.T_SYS_Informatikrechte = new HashSet<T_SYS_Informatikrechte>();
            this.T_TM_Tasks_Planung = new HashSet<T_TM_Tasks_Planung>();
            this.T_TM_Tasks = new HashSet<T_TM_Tasks>();
            this.T_ZO_AP_Informatik_DWG = new HashSet<T_ZO_AP_Informatik_DWG>();
        }
    
        public System.Guid IN_UID { get; set; }
        public int IN_MDT_ID { get; set; }
        public Nullable<System.Guid> IN_RM_UID { get; set; }
        public Nullable<System.Guid> IN_IKAT_UID { get; set; }
        public Nullable<System.Guid> IN_ADR_UID { get; set; }
        public Nullable<System.Guid> IN_IBS_UID { get; set; }
        public Nullable<System.Guid> IN_KST_UID { get; set; }
        public string IN_ApertureKey { get; set; }
        public string IN_Nr { get; set; }
        public string IN_Hersteller { get; set; }
        public string IN_Modell { get; set; }
        public string IN_Typ { get; set; }
        public string IN_TypenNr { get; set; }
        public string IN_SerienNr { get; set; }
        public string IN_IP { get; set; }
        public string IN_Computername { get; set; }
        public Nullable<System.DateTime> IN_Inbetriebnahme { get; set; }
        public string IN_Bezeichnung { get; set; }
        public string IN_Bemerkung { get; set; }
        public System.DateTime IN_DatumVon { get; set; }
        public System.DateTime IN_DatumBis { get; set; }
        public int IN_Status { get; set; }
        public Nullable<System.Guid> IN_AP_UID { get; set; }
    
        public virtual T_AP_Arbeitsplatz T_AP_Arbeitsplatz { get; set; }
        public virtual ICollection<T_AP_Informatik_History> T_AP_Informatik_History { get; set; }
        public virtual T_AP_Raum T_AP_Raum { get; set; }
        public virtual T_AP_Ref_InformatikBetriebssystem T_AP_Ref_InformatikBetriebssystem { get; set; }
        public virtual T_AP_Ref_InformatikKategorie T_AP_Ref_InformatikKategorie { get; set; }
        public virtual T_AP_Ref_Kostenstelle T_AP_Ref_Kostenstelle { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_AV_Adressen T_AV_Adressen { get; set; }
        public virtual ICollection<T_SYS_Informatikrechte> T_SYS_Informatikrechte { get; set; }
        public virtual ICollection<T_TM_Tasks_Planung> T_TM_Tasks_Planung { get; set; }
        public virtual ICollection<T_TM_Tasks> T_TM_Tasks { get; set; }
        public virtual ICollection<T_ZO_AP_Informatik_DWG> T_ZO_AP_Informatik_DWG { get; set; }
    }
}

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
    
    public partial class T_AP_Mobiliar
    {
        public T_AP_Mobiliar()
        {
            this.T_AP_Mobiliar_History = new HashSet<T_AP_Mobiliar_History>();
            this.T_AP_Schluessel = new HashSet<T_AP_Schluessel>();
            this.T_SYS_Mobiliarrechte = new HashSet<T_SYS_Mobiliarrechte>();
            this.T_TM_Tasks_Planung = new HashSet<T_TM_Tasks_Planung>();
            this.T_TM_Tasks = new HashSet<T_TM_Tasks>();
            this.T_ZO_AP_Mobiliar_DWG = new HashSet<T_ZO_AP_Mobiliar_DWG>();
        }
    
        public System.Guid MO_UID { get; set; }
        public string MO_ApertureKey { get; set; }
        public string MO_Nr { get; set; }
        public Nullable<System.DateTime> MO_Anschaffungsdatum { get; set; }
        public double MO_Kaufpreis { get; set; }
        public string MO_Bemerkung { get; set; }
        public System.DateTime MO_DatumVon { get; set; }
        public System.DateTime MO_DatumBis { get; set; }
        public int MO_Status { get; set; }
        public bool MO_IsAutoCreate { get; set; }
        public Nullable<bool> MO_canHaveKey { get; set; }
    
        public virtual T_AP_Arbeitsplatz T_AP_Arbeitsplatz { get; set; }
        public virtual ICollection<T_AP_Mobiliar_History> T_AP_Mobiliar_History { get; set; }
        public virtual T_AP_Raum T_AP_Raum { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_AP_Ref_MobiliarBibliothek T_AP_Ref_MobiliarBibliothek { get; set; }
        public virtual T_AP_Ref_MobiliarFarbe T_AP_Ref_MobiliarFarbe { get; set; }
        public virtual T_AV_Adressen T_AV_Adressen { get; set; }
        public virtual ICollection<T_AP_Schluessel> T_AP_Schluessel { get; set; }
        public virtual ICollection<T_SYS_Mobiliarrechte> T_SYS_Mobiliarrechte { get; set; }
        public virtual ICollection<T_TM_Tasks_Planung> T_TM_Tasks_Planung { get; set; }
        public virtual ICollection<T_TM_Tasks> T_TM_Tasks { get; set; }
        public virtual ICollection<T_ZO_AP_Mobiliar_DWG> T_ZO_AP_Mobiliar_DWG { get; set; }
    }
}

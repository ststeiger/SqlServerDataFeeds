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
    
    public partial class T_AP_Schluesselgruppe
    {
        public T_AP_Schluesselgruppe()
        {
            this.T_AP_Schluessel = new HashSet<T_AP_Schluessel>();
            this.T_AP_Schluesselgruppe_History = new HashSet<T_AP_Schluesselgruppe_History>();
            this.T_SYS_Schluesselgrupperechte = new HashSet<T_SYS_Schluesselgrupperechte>();
            this.T_TM_Tasks_Planung = new HashSet<T_TM_Tasks_Planung>();
            this.T_TM_Tasks = new HashSet<T_TM_Tasks>();
            this.T_ZO_AP_Schluesselgruppe_AP_Ref_Funktionen = new HashSet<T_ZO_AP_Schluesselgruppe_AP_Ref_Funktionen>();
            this.T_ZO_AP_Schluesselgruppe_AP_Zylinder = new HashSet<T_ZO_AP_Schluesselgruppe_AP_Zylinder>();
            this.T_ZO_AP_Zylinder_AP_Schluesselgruppe_Benutzer = new HashSet<T_ZO_AP_Zylinder_AP_Schluesselgruppe_Benutzer>();
            this.T_AP_Ref_Mandant = new HashSet<T_AP_Ref_Mandant>();
        }
    
        public System.Guid SLG_UID { get; set; }
        public int SLG_MDT_ID { get; set; }
        public Nullable<System.Guid> SLG_SKAT_UID { get; set; }
        public Nullable<System.Guid> SLG_STYP_UID { get; set; }
        public Nullable<System.Guid> SLG_ZSYS_UID { get; set; }
        public string SLG_ApertureKey { get; set; }
        public string SLG_Nr { get; set; }
        public string SLG_Bezeichnung { get; set; }
        public string SLG_Bemerkung { get; set; }
        public System.DateTime SLG_DatumVon { get; set; }
        public System.DateTime SLG_DatumBis { get; set; }
        public int SLG_Status { get; set; }
    
        public virtual T_AP_Ref_SchluesselKategorie T_AP_Ref_SchluesselKategorie { get; set; }
        public virtual T_AP_Ref_SchluesselTyp T_AP_Ref_SchluesselTyp { get; set; }
        public virtual T_AP_Ref_ZylinderSchliesssystem T_AP_Ref_ZylinderSchliesssystem { get; set; }
        public virtual ICollection<T_AP_Schluessel> T_AP_Schluessel { get; set; }
        public virtual ICollection<T_AP_Schluesselgruppe_History> T_AP_Schluesselgruppe_History { get; set; }
        public virtual ICollection<T_SYS_Schluesselgrupperechte> T_SYS_Schluesselgrupperechte { get; set; }
        public virtual ICollection<T_TM_Tasks_Planung> T_TM_Tasks_Planung { get; set; }
        public virtual ICollection<T_TM_Tasks> T_TM_Tasks { get; set; }
        public virtual ICollection<T_ZO_AP_Schluesselgruppe_AP_Ref_Funktionen> T_ZO_AP_Schluesselgruppe_AP_Ref_Funktionen { get; set; }
        public virtual ICollection<T_ZO_AP_Schluesselgruppe_AP_Zylinder> T_ZO_AP_Schluesselgruppe_AP_Zylinder { get; set; }
        public virtual ICollection<T_ZO_AP_Zylinder_AP_Schluesselgruppe_Benutzer> T_ZO_AP_Zylinder_AP_Schluesselgruppe_Benutzer { get; set; }
        public virtual ICollection<T_AP_Ref_Mandant> T_AP_Ref_Mandant { get; set; }
    }
}

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
    
    public partial class T_TM_Ref_TaskPrio
    {
        public T_TM_Ref_TaskPrio()
        {
            this.T_TM_Tasks = new HashSet<T_TM_Tasks>();
        }
    
        public System.Guid TPRI_UID { get; set; }
        public Nullable<int> TPRI_Code { get; set; }
        public string TPRI_Kurz_DE { get; set; }
        public string TPRI_Kurz_FR { get; set; }
        public string TPRI_Kurz_IT { get; set; }
        public string TPRI_Kurz_EN { get; set; }
        public string TPRI_Lang_DE { get; set; }
        public string TPRI_Lang_FR { get; set; }
        public string TPRI_Lang_IT { get; set; }
        public string TPRI_Lang_EN { get; set; }
        public int TPRI_Status { get; set; }
        public int TPRI_Sort { get; set; }
        public Nullable<int> TPRI_StylizerBack { get; set; }
        public Nullable<int> TPRI_StylizerPattern { get; set; }
        public Nullable<int> TPRI_StylizerLine { get; set; }
        public bool TPRI_IsDefault { get; set; }
        public Nullable<System.DateTime> TPRI_DatumMut { get; set; }
        public string TPRI_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        public virtual ICollection<T_TM_Tasks> T_TM_Tasks { get; set; }
    }
}

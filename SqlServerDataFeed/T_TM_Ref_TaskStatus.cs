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
    
    public partial class T_TM_Ref_TaskStatus
    {
        public T_TM_Ref_TaskStatus()
        {
            this.T_TM_Tasks = new HashSet<T_TM_Tasks>();
            this.T_ZO_TM_TSTA_TSK = new HashSet<T_ZO_TM_TSTA_TSK>();
        }
    
        public System.Guid TSTA_UID { get; set; }
        public int TSTA_MDT_ID { get; set; }
        public Nullable<int> TSTA_Code { get; set; }
        public string TSTA_Kurz_DE { get; set; }
        public string TSTA_Kurz_FR { get; set; }
        public string TSTA_Kurz_IT { get; set; }
        public string TSTA_Kurz_EN { get; set; }
        public string TSTA_Lang_DE { get; set; }
        public string TSTA_Lang_FR { get; set; }
        public string TSTA_Lang_IT { get; set; }
        public string TSTA_Lang_EN { get; set; }
        public int TSTA_Status { get; set; }
        public int TSTA_Sort { get; set; }
        public Nullable<int> TSTA_StylizerFore { get; set; }
        public Nullable<int> TSTA_StylizerBack { get; set; }
        public Nullable<int> TSTA_StylizerPattern { get; set; }
        public Nullable<int> TSTA_StylizerLine { get; set; }
        public bool TSTA_IsDefault { get; set; }
        public Nullable<System.DateTime> TSTA_DatumMut { get; set; }
        public string TSTA_DatumUser { get; set; }
        public bool TSTA_IsStoerung { get; set; }
        public Nullable<bool> TSTA_IsDone { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual ICollection<T_TM_Tasks> T_TM_Tasks { get; set; }
        public virtual ICollection<T_ZO_TM_TSTA_TSK> T_ZO_TM_TSTA_TSK { get; set; }
    }
}

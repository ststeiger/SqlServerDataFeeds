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
    
    public partial class T_VM_Ref_KostenPeriode
    {
        public T_VM_Ref_KostenPeriode()
        {
            this.T_VM_Vertraege = new HashSet<T_VM_Vertraege>();
        }
    
        public System.Guid KP_UID { get; set; }
        public int KP_MDT_ID { get; set; }
        public Nullable<int> KP_Code { get; set; }
        public string KP_Kurz_DE { get; set; }
        public string KP_Kurz_FR { get; set; }
        public string KP_Kurz_IT { get; set; }
        public string KP_Kurz_EN { get; set; }
        public string KP_Lang_DE { get; set; }
        public string KP_Lang_FR { get; set; }
        public string KP_Lang_IT { get; set; }
        public string KP_Lang_EN { get; set; }
        public int KP_Status { get; set; }
        public int KP_Sort { get; set; }
        public Nullable<int> KP_StylizerFore { get; set; }
        public Nullable<int> KP_StylizerBack { get; set; }
        public Nullable<int> KP_StylizerPattern { get; set; }
        public Nullable<int> KP_StylizerLine { get; set; }
        public bool KP_IsDefault { get; set; }
        public Nullable<System.DateTime> KP_DatumMut { get; set; }
        public string KP_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual ICollection<T_VM_Vertraege> T_VM_Vertraege { get; set; }
    }
}

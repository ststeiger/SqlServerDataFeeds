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
    
    public partial class T_AP_Ref_KunstStatus
    {
        public T_AP_Ref_KunstStatus()
        {
            this.T_AP_Kunst = new HashSet<T_AP_Kunst>();
        }
    
        public System.Guid KS_UID { get; set; }
        public string KS_Code { get; set; }
        public string KS_Kurz_DE { get; set; }
        public string KS_Kurz_FR { get; set; }
        public string KS_Kurz_IT { get; set; }
        public string KS_Kurz_EN { get; set; }
        public string KS_Lang_DE { get; set; }
        public string KS_Lang_FR { get; set; }
        public string KS_Lang_IT { get; set; }
        public string KS_Lang_EN { get; set; }
        public int KS_Status { get; set; }
        public int KS_Sort { get; set; }
        public Nullable<int> KS_StylizerBack { get; set; }
        public Nullable<int> KS_StylizerPattern { get; set; }
        public Nullable<int> KS_StylizerLine { get; set; }
        public bool KS_IsDefault { get; set; }
        public Nullable<System.DateTime> KS_DatumMut { get; set; }
        public string KS_DatumUser { get; set; }
    
        public virtual ICollection<T_AP_Kunst> T_AP_Kunst { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

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
    
    public partial class T_AP_Ref_ErschliessungFussweg
    {
        public T_AP_Ref_ErschliessungFussweg()
        {
            this.T_AP_Gebaeude = new HashSet<T_AP_Gebaeude>();
        }
    
        public System.Guid ERF_UID { get; set; }
        public Nullable<int> ERF_Code { get; set; }
        public string ERF_Kurz_DE { get; set; }
        public string ERF_Kurz_FR { get; set; }
        public string ERF_Kurz_IT { get; set; }
        public string ERF_Kurz_EN { get; set; }
        public string ERF_Lang_DE { get; set; }
        public string ERF_Lang_FR { get; set; }
        public string ERF_Lang_IT { get; set; }
        public string ERF_Lang_EN { get; set; }
        public int ERF_Status { get; set; }
        public int ERF_Sort { get; set; }
        public Nullable<int> ERF_StylizerBack { get; set; }
        public Nullable<int> ERF_StylizerPattern { get; set; }
        public Nullable<int> ERF_StylizerLine { get; set; }
        public bool ERF_IsDefault { get; set; }
        public Nullable<System.DateTime> ERF_DatumMut { get; set; }
        public string ERF_DatumUser { get; set; }
    
        public virtual ICollection<T_AP_Gebaeude> T_AP_Gebaeude { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

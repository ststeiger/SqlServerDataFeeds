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
    
    public partial class T_AP_Ref_TuerBrandschutz
    {
        public T_AP_Ref_TuerBrandschutz()
        {
            this.T_AP_Tuer = new HashSet<T_AP_Tuer>();
        }
    
        public System.Guid TBS_UID { get; set; }
        public Nullable<int> TBS_Code { get; set; }
        public string TBS_Kurz_DE { get; set; }
        public string TBS_Kurz_FR { get; set; }
        public string TBS_Kurz_IT { get; set; }
        public string TBS_Kurz_EN { get; set; }
        public string TBS_Lang_DE { get; set; }
        public string TBS_Lang_FR { get; set; }
        public string TBS_Lang_IT { get; set; }
        public string TBS_Lang_EN { get; set; }
        public int TBS_Status { get; set; }
        public int TBS_Sort { get; set; }
        public Nullable<int> TBS_StylizerBack { get; set; }
        public Nullable<int> TBS_StylizerPattern { get; set; }
        public Nullable<int> TBS_StylizerLine { get; set; }
        public bool TBS_IsDefault { get; set; }
        public Nullable<System.DateTime> TBS_DatumMut { get; set; }
        public string TBS_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        public virtual ICollection<T_AP_Tuer> T_AP_Tuer { get; set; }
    }
}

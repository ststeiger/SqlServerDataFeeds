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
    
    public partial class T_AP_Ref_KunstRahmenArt
    {
        public T_AP_Ref_KunstRahmenArt()
        {
            this.T_AP_Kunst = new HashSet<T_AP_Kunst>();
        }
    
        public System.Guid KR_UID { get; set; }
        public Nullable<int> KR_Code { get; set; }
        public string KR_Kurz_DE { get; set; }
        public string KR_Kurz_FR { get; set; }
        public string KR_Kurz_IT { get; set; }
        public string KR_Kurz_EN { get; set; }
        public string KR_Lang_DE { get; set; }
        public string KR_Lang_FR { get; set; }
        public string KR_Lang_IT { get; set; }
        public string KR_Lang_EN { get; set; }
        public int KR_Status { get; set; }
        public int KR_Sort { get; set; }
        public Nullable<int> KR_StylizerBack { get; set; }
        public Nullable<int> KR_StylizerPattern { get; set; }
        public Nullable<int> KR_StylizerLine { get; set; }
        public bool KR_IsDefault { get; set; }
        public bool KR_IsFreeText { get; set; }
        public Nullable<System.DateTime> KR_DatumMut { get; set; }
        public string KR_DatumUser { get; set; }
    
        public virtual ICollection<T_AP_Kunst> T_AP_Kunst { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

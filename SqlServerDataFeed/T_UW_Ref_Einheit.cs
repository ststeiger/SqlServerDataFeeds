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
    
    public partial class T_UW_Ref_Einheit
    {
        public T_UW_Ref_Einheit()
        {
            this.T_UW_Ref_Bereich = new HashSet<T_UW_Ref_Bereich>();
        }
    
        public System.Guid UWE_UID { get; set; }
        public Nullable<int> UWE_Code { get; set; }
        public string UWE_Kurz_DE { get; set; }
        public string UWE_Kurz_FR { get; set; }
        public string UWE_Kurz_IT { get; set; }
        public string UWE_Kurz_EN { get; set; }
        public string UWE_Lang_DE { get; set; }
        public string UWE_Lang_FR { get; set; }
        public string UWE_Lang_IT { get; set; }
        public string UWE_Lang_EN { get; set; }
        public int UWE_Status { get; set; }
        public int UWE_Sort { get; set; }
        public Nullable<int> UWE_StylizerBack { get; set; }
        public Nullable<int> UWE_StylizerPattern { get; set; }
        public Nullable<int> UWE_StylizerLine { get; set; }
        public bool UWE_IsDefault { get; set; }
        public Nullable<System.DateTime> UWE_DatumMut { get; set; }
        public string UWE_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        public virtual ICollection<T_UW_Ref_Bereich> T_UW_Ref_Bereich { get; set; }
    }
}

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
    
    public partial class T_AP_Ref_AnschlussSwitch
    {
        public T_AP_Ref_AnschlussSwitch()
        {
            this.T_AP_Anschluss = new HashSet<T_AP_Anschluss>();
        }
    
        public System.Guid ASWI_UID { get; set; }
        public Nullable<int> ASWI_Code { get; set; }
        public string ASWI_Kurz_DE { get; set; }
        public string ASWI_Kurz_FR { get; set; }
        public string ASWI_Kurz_IT { get; set; }
        public string ASWI_Kurz_EN { get; set; }
        public string ASWI_Lang_DE { get; set; }
        public string ASWI_Lang_FR { get; set; }
        public string ASWI_Lang_IT { get; set; }
        public string ASWI_Lang_EN { get; set; }
        public int ASWI_Status { get; set; }
        public int ASWI_Sort { get; set; }
        public Nullable<int> ASWI_StylizerBack { get; set; }
        public Nullable<int> ASWI_StylizerPattern { get; set; }
        public Nullable<int> ASWI_StylizerLine { get; set; }
        public bool ASWI_IsDefault { get; set; }
        public Nullable<System.DateTime> ASWI_DatumMut { get; set; }
        public string ASWI_DatumUser { get; set; }
    
        public virtual ICollection<T_AP_Anschluss> T_AP_Anschluss { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

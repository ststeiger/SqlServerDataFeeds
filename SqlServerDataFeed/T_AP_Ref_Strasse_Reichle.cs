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
    
    public partial class T_AP_Ref_Strasse_Reichle
    {
        public T_AP_Ref_Strasse_Reichle()
        {
            this.T_AP_Gebaeude_Reichle = new HashSet<T_AP_Gebaeude_Reichle>();
        }
    
        public System.Guid STR_UID { get; set; }
        public string STR_Code { get; set; }
        public string STR_Kurz_DE { get; set; }
        public string STR_Kurz_FR { get; set; }
        public string STR_Kurz_IT { get; set; }
        public string STR_Kurz_EN { get; set; }
        public string STR_Lang_DE { get; set; }
        public string STR_Lang_FR { get; set; }
        public string STR_Lang_IT { get; set; }
        public string STR_Lang_EN { get; set; }
        public int STR_Status { get; set; }
        public int STR_Sort { get; set; }
        public Nullable<int> STR_StylizerBack { get; set; }
        public Nullable<int> STR_StylizerPattern { get; set; }
        public Nullable<int> STR_StylizerLine { get; set; }
        public bool STR_IsDefault { get; set; }
        public Nullable<System.DateTime> STR_DatumMut { get; set; }
        public string STR_DatumUser { get; set; }
    
        public virtual ICollection<T_AP_Gebaeude_Reichle> T_AP_Gebaeude_Reichle { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

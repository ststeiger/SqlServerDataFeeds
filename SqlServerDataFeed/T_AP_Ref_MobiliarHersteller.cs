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
    
    public partial class T_AP_Ref_MobiliarHersteller
    {
        public T_AP_Ref_MobiliarHersteller()
        {
            this.T_AP_Ref_MobiliarBibliothek = new HashSet<T_AP_Ref_MobiliarBibliothek>();
        }
    
        public System.Guid MH_UID { get; set; }
        public Nullable<int> MH_Code { get; set; }
        public string MH_Kurz_DE { get; set; }
        public string MH_Kurz_FR { get; set; }
        public string MH_Kurz_IT { get; set; }
        public string MH_Kurz_EN { get; set; }
        public string MH_Lang_DE { get; set; }
        public string MH_Lang_FR { get; set; }
        public string MH_Lang_IT { get; set; }
        public string MH_Lang_EN { get; set; }
        public int MH_Status { get; set; }
        public int MH_Sort { get; set; }
        public Nullable<int> MH_StylizerBack { get; set; }
        public Nullable<int> MH_StylizerPattern { get; set; }
        public Nullable<int> MH_StylizerLine { get; set; }
        public bool MH_IsDefault { get; set; }
        public Nullable<System.DateTime> MH_DatumMut { get; set; }
        public string MH_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual ICollection<T_AP_Ref_MobiliarBibliothek> T_AP_Ref_MobiliarBibliothek { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

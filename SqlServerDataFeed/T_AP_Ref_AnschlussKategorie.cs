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
    
    public partial class T_AP_Ref_AnschlussKategorie
    {
        public T_AP_Ref_AnschlussKategorie()
        {
            this.T_AP_Anschluss = new HashSet<T_AP_Anschluss>();
            this.T_AP_Ref_AnschlussTyp = new HashSet<T_AP_Ref_AnschlussTyp>();
        }
    
        public System.Guid ANKAT_UID { get; set; }
        public Nullable<int> ANKAT_Code { get; set; }
        public string ANKAT_Kurz_DE { get; set; }
        public string ANKAT_Kurz_FR { get; set; }
        public string ANKAT_Kurz_IT { get; set; }
        public string ANKAT_Kurz_EN { get; set; }
        public string ANKAT_Lang_DE { get; set; }
        public string ANKAT_Lang_FR { get; set; }
        public string ANKAT_Lang_IT { get; set; }
        public string ANKAT_Lang_EN { get; set; }
        public int ANKAT_Status { get; set; }
        public int ANKAT_Sort { get; set; }
        public Nullable<int> ANKAT_StylizerBack { get; set; }
        public Nullable<int> ANKAT_StylizerPattern { get; set; }
        public Nullable<int> ANKAT_StylizerLine { get; set; }
        public bool ANKAT_IsDefault { get; set; }
        public Nullable<System.DateTime> ANKAT_DatumMut { get; set; }
        public string ANKAT_DatumUser { get; set; }
    
        public virtual ICollection<T_AP_Anschluss> T_AP_Anschluss { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        public virtual ICollection<T_AP_Ref_AnschlussTyp> T_AP_Ref_AnschlussTyp { get; set; }
    }
}

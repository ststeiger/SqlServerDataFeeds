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
    
    public partial class T_AP_Ref_MobiliarBibliothek
    {
        public T_AP_Ref_MobiliarBibliothek()
        {
            this.T_AP_Mobiliar = new HashSet<T_AP_Mobiliar>();
            this.T_AP_Ref_MobiliarBibliothek_Raiffeisen = new HashSet<T_AP_Ref_MobiliarBibliothek_Raiffeisen>();
        }
    
        public System.Guid MB_UID { get; set; }
        public int MB_MDT_ID { get; set; }
        public Nullable<System.Guid> MB_MKAT_UID { get; set; }
        public Nullable<System.Guid> MB_MM_UID { get; set; }
        public Nullable<System.Guid> MB_MH_UID { get; set; }
        public string MB_Bezeichnung { get; set; }
        public string MB_Abmessung { get; set; }
        public string MB_Bemerkung { get; set; }
        public int MB_StylizerFore { get; set; }
        public int MB_StylizerBack { get; set; }
        public int MB_StylizerPattern { get; set; }
        public int MB_StylizerLine { get; set; }
        public int MB_Status { get; set; }
        public int MB_Sort { get; set; }
        public string MB_Bild { get; set; }
        public int MB_BildWidth { get; set; }
        public int MB_BildHeight { get; set; }
    
        public virtual ICollection<T_AP_Mobiliar> T_AP_Mobiliar { get; set; }
        public virtual ICollection<T_AP_Ref_MobiliarBibliothek_Raiffeisen> T_AP_Ref_MobiliarBibliothek_Raiffeisen { get; set; }
        public virtual T_AP_Ref_MobiliarHersteller T_AP_Ref_MobiliarHersteller { get; set; }
        public virtual T_AP_Ref_MobiliarKategorie T_AP_Ref_MobiliarKategorie { get; set; }
        public virtual T_AP_Ref_MobiliarMaterial T_AP_Ref_MobiliarMaterial { get; set; }
    }
}

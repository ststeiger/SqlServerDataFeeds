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
    
    public partial class T_Ref_ValidDocuments
    {
        public System.Guid VD_UID { get; set; }
        public string VD_Code { get; set; }
        public int VD_Status { get; set; }
        public int VD_Sort { get; set; }
        public bool VD_IsDefault { get; set; }
        public Nullable<int> VD_StylizerFore { get; set; }
        public Nullable<int> VD_StylizerPattern { get; set; }
        public int VD_MDT_ID { get; set; }
        public string VD_Kurz_de { get; set; }
        public string VD_Kurz_fr { get; set; }
        public string VD_Kurz_it { get; set; }
        public string VD_Kurz_en { get; set; }
        public string VD_Lang_de { get; set; }
        public string VD_Lang_fr { get; set; }
        public string VD_Lang_it { get; set; }
        public string VD_Lang_en { get; set; }
        public Nullable<int> VD_StylizerLine { get; set; }
    
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

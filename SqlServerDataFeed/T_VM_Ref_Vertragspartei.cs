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
    
    public partial class T_VM_Ref_Vertragspartei
    {
        public T_VM_Ref_Vertragspartei()
        {
            this.T_VM_Vertraege = new HashSet<T_VM_Vertraege>();
        }
    
        public System.Guid VTP_UID { get; set; }
        public Nullable<int> VTP_Code { get; set; }
        public string VTP_Kurz_DE { get; set; }
        public string VTP_Kurz_FR { get; set; }
        public string VTP_Kurz_IT { get; set; }
        public string VTP_Kurz_EN { get; set; }
        public string VTP_Lang_DE { get; set; }
        public string VTP_Lang_FR { get; set; }
        public string VTP_Lang_IT { get; set; }
        public string VTP_Lang_EN { get; set; }
        public int VTP_Status { get; set; }
        public int VTP_Sort { get; set; }
        public Nullable<int> VTP_StylizerBack { get; set; }
        public Nullable<int> VTP_StylizerPattern { get; set; }
        public Nullable<int> VTP_StylizerLine { get; set; }
        public bool VTP_IsDefault { get; set; }
        public Nullable<System.DateTime> VTP_DatumMut { get; set; }
        public string VTP_DatumUser { get; set; }
    
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        public virtual ICollection<T_VM_Vertraege> T_VM_Vertraege { get; set; }
    }
}

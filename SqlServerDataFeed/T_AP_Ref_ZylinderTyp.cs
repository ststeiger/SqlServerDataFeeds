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
    
    public partial class T_AP_Ref_ZylinderTyp
    {
        public T_AP_Ref_ZylinderTyp()
        {
            this.T_AP_Zylinder = new HashSet<T_AP_Zylinder>();
        }
    
        public System.Guid ZYLT_UID { get; set; }
        public Nullable<int> ZYLT_Code { get; set; }
        public string ZYLT_Kurz_DE { get; set; }
        public string ZYLT_Kurz_FR { get; set; }
        public string ZYLT_Kurz_IT { get; set; }
        public string ZYLT_Kurz_EN { get; set; }
        public string ZYLT_Lang_DE { get; set; }
        public string ZYLT_Lang_FR { get; set; }
        public string ZYLT_Lang_IT { get; set; }
        public string ZYLT_Lang_EN { get; set; }
        public int ZYLT_Status { get; set; }
        public int ZYLT_Sort { get; set; }
        public Nullable<int> ZYLT_StylizerBack { get; set; }
        public Nullable<int> ZYLT_StylizerPattern { get; set; }
        public Nullable<int> ZYLT_StylizerLine { get; set; }
        public bool ZYLT_IsDefault { get; set; }
        public Nullable<System.DateTime> ZYLT_DatumMut { get; set; }
        public string ZYLT_DatumUser { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        public virtual ICollection<T_AP_Zylinder> T_AP_Zylinder { get; set; }
    }
}

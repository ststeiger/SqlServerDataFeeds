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
    
    public partial class T_AP_Ref_KontaktGeschlecht
    {
        public T_AP_Ref_KontaktGeschlecht()
        {
            this.T_AP_Kontakte = new HashSet<T_AP_Kontakte>();
        }
    
        public System.Guid KG_UID { get; set; }
        public int KG_MDT_ID { get; set; }
        public Nullable<int> KG_Code { get; set; }
        public string KG_Kurz_DE { get; set; }
        public string KG_Kurz_FR { get; set; }
        public string KG_Kurz_IT { get; set; }
        public string KG_Kurz_EN { get; set; }
        public string KG_Lang_DE { get; set; }
        public string KG_Lang_FR { get; set; }
        public string KG_Lang_IT { get; set; }
        public string KG_Lang_EN { get; set; }
        public int KG_Status { get; set; }
        public int KG_Sort { get; set; }
        public Nullable<int> KG_StylizerFore { get; set; }
        public Nullable<int> KG_StylizerBack { get; set; }
        public Nullable<int> KG_StylizerPattern { get; set; }
        public Nullable<int> KG_StylizerLine { get; set; }
        public bool KG_IsDefault { get; set; }
        public Nullable<System.DateTime> KG_DatumMut { get; set; }
        public string KG_DatumUser { get; set; }
    
        public virtual ICollection<T_AP_Kontakte> T_AP_Kontakte { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
    }
}

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
    
    public partial class T_UM_Ref_Status
    {
        public T_UM_Ref_Status()
        {
            this.T_UM_Planung = new HashSet<T_UM_Planung>();
        }
    
        public System.Guid UMST_UID { get; set; }
        public Nullable<int> UMST_Code { get; set; }
        public string UMST_Kurz_DE { get; set; }
        public string UMST_Kurz_FR { get; set; }
        public string UMST_Kurz_IT { get; set; }
        public string UMST_Kurz_EN { get; set; }
        public string UMST_Lang_DE { get; set; }
        public string UMST_Lang_FR { get; set; }
        public string UMST_Lang_IT { get; set; }
        public string UMST_Lang_EN { get; set; }
        public int UMST_Status { get; set; }
        public int UMST_Sort { get; set; }
        public bool UMST_IsDefault { get; set; }
        public Nullable<int> UMST_StylizerBack { get; set; }
        public Nullable<int> UMST_StylizerFore { get; set; }
        public Nullable<int> UMST_StylizerPattern { get; set; }
        public Nullable<int> UMST_StylizerLine { get; set; }
        public int UMST_MDT_ID { get; set; }
    
        public virtual ICollection<T_UM_Planung> T_UM_Planung { get; set; }
    }
}

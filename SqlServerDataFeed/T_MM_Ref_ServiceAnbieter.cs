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
    
    public partial class T_MM_Ref_ServiceAnbieter
    {
        public T_MM_Ref_ServiceAnbieter()
        {
            this.T_ZO_MM_Standort_ServiceAnbieter = new HashSet<T_ZO_MM_Standort_ServiceAnbieter>();
        }
    
        public System.Guid MMSA_UID { get; set; }
        public string MMSA_Code { get; set; }
        public int MMSA_Status { get; set; }
        public int MMSA_Sort { get; set; }
        public bool MMSA_IsDefault { get; set; }
        public Nullable<int> MMSA_StylizerBack { get; set; }
        public Nullable<int> MMSA_StylizerFore { get; set; }
        public Nullable<int> MMSA_StylizerPattern { get; set; }
        public int MMSA_MDT_ID { get; set; }
        public string MMSA_Name { get; set; }
        public string MMSA_Vorname { get; set; }
        public string MMSA_Email { get; set; }
        public Nullable<int> MMSA_StylizerLine { get; set; }
    
        public virtual ICollection<T_ZO_MM_Standort_ServiceAnbieter> T_ZO_MM_Standort_ServiceAnbieter { get; set; }
    }
}

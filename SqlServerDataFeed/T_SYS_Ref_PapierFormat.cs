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
    
    public partial class T_SYS_Ref_PapierFormat
    {
        public T_SYS_Ref_PapierFormat()
        {
            this.T_SYS_Legendenkonfiguration = new HashSet<T_SYS_Legendenkonfiguration>();
        }
    
        public System.Guid PF_UID { get; set; }
        public string PF_NormGiver { get; set; }
        public string PF_Name { get; set; }
        public string PF_CompoundSize { get; set; }
        public Nullable<decimal> PF_WidthInMM { get; set; }
        public Nullable<decimal> PF_HeightInMM { get; set; }
        public int PF_Sort { get; set; }
        public int PF_Status { get; set; }
    
        public virtual ICollection<T_SYS_Legendenkonfiguration> T_SYS_Legendenkonfiguration { get; set; }
    }
}

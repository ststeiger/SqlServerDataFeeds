//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SqlServerDataFeedEF6
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_VAR_Projekt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_VAR_Projekt()
        {
            this.T_VAR_Variante = new HashSet<T_VAR_Variante>();
        }
    
        public System.Guid PRJ_UID { get; set; }
        public string PRJ_ApertureKey { get; set; }
        public string PRJ_Nr { get; set; }
        public string PRJ_Bezeichnung { get; set; }
        public string PRJ_Bemerkung { get; set; }
        public System.DateTime PRJ_DatumVon { get; set; }
        public System.DateTime PRJ_DatumBis { get; set; }
        public int PRJ_Status { get; set; }
        public Nullable<System.DateTime> PRJ_MutDate { get; set; }
        public string PRJ_MutUser { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_VAR_Variante> T_VAR_Variante { get; set; }
    }
}
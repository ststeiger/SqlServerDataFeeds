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
    
    public partial class T_FMS_Dashboard
    {
        public T_FMS_Dashboard()
        {
            this.T_FMS_Dashboard1 = new HashSet<T_FMS_Dashboard>();
        }
    
        public System.Guid DB_UID { get; set; }
        public Nullable<System.Guid> DB_DB_UID { get; set; }
        public Nullable<System.Guid> DB_FT_UID { get; set; }
        public string DB_Link { get; set; }
        public int DB_Sort { get; set; }
        public int DB_Status { get; set; }
    
        public virtual ICollection<T_FMS_Dashboard> T_FMS_Dashboard1 { get; set; }
        public virtual T_FMS_Dashboard T_FMS_Dashboard2 { get; set; }
    }
}

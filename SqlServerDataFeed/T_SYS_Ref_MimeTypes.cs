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
    
    public partial class T_SYS_Ref_MimeTypes
    {
        public T_SYS_Ref_MimeTypes()
        {
            this.T_ZO_SYS_Mimetyperechte_Benutzergruppe = new HashSet<T_ZO_SYS_Mimetyperechte_Benutzergruppe>();
        }
    
        public System.Guid MIME_UID { get; set; }
        public string MIME_Name { get; set; }
        public string MIME_FileExtension { get; set; }
        public string MIME_FileExtensionNoPoint { get; set; }
        public string MIME_Type { get; set; }
        public string MIME_Details { get; set; }
        public Nullable<bool> MIME_IsAllowed { get; set; }
    
        public virtual ICollection<T_ZO_SYS_Mimetyperechte_Benutzergruppe> T_ZO_SYS_Mimetyperechte_Benutzergruppe { get; set; }
    }
}

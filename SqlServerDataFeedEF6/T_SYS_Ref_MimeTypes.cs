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
    
    public partial class T_SYS_Ref_MimeTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
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
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_SYS_Mimetyperechte_Benutzergruppe> T_ZO_SYS_Mimetyperechte_Benutzergruppe { get; set; }
    }
}

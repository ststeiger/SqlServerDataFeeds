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
    
    public partial class T_Slicklist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Slicklist()
        {
            this.T_Slicklist_Custom = new HashSet<T_Slicklist_Custom>();
            this.T_ZO_Slickcolumn = new HashSet<T_ZO_Slickcolumn>();
        }
    
        public System.Guid SL_UID { get; set; }
        public string SL_SQL { get; set; }
        public Nullable<bool> SL_asyncEditorLoading { get; set; }
        public Nullable<bool> SL_autoEdit { get; set; }
        public Nullable<bool> SL_autoHeight { get; set; }
        public Nullable<short> SL_defaultColumnWidth { get; set; }
        public Nullable<bool> SL_editable { get; set; }
        public Nullable<bool> SL_editOnDoubleClick { get; set; }
        public Nullable<bool> SL_enableAddRow { get; set; }
        public Nullable<bool> SL_enableCellNavigation { get; set; }
        public Nullable<bool> SL_enableCellRangeSelection { get; set; }
        public Nullable<bool> SL_enableColumnReorder { get; set; }
        public Nullable<bool> SL_forceFitColumns { get; set; }
        public Nullable<bool> SL_leaveSpaceForNewRows { get; set; }
        public Nullable<bool> SL_manualScrolling { get; set; }
        public Nullable<bool> SL_multiSelect { get; set; }
        public Nullable<bool> SL_rerenderOnResize { get; set; }
        public Nullable<bool> SL_secondaryHeaderRowHeight { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Slicklist_Custom> T_Slicklist_Custom { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_Slickcolumn> T_ZO_Slickcolumn { get; set; }
    }
}
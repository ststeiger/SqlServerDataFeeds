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
    
    public partial class T_Slicklist_Custom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Slicklist_Custom()
        {
            this.T_ZO_Slickcolumn_Custom = new HashSet<T_ZO_Slickcolumn_Custom>();
        }
    
        public System.Guid SLC_UID { get; set; }
        public System.Guid SLC_SL_UID { get; set; }
        public Nullable<bool> SLC_asyncEditorLoading { get; set; }
        public Nullable<bool> SLC_autoEdit { get; set; }
        public Nullable<bool> SLC_autoHeight { get; set; }
        public Nullable<short> SLC_defaultColumnWidth { get; set; }
        public Nullable<bool> SLC_editable { get; set; }
        public Nullable<bool> SLC_editOnDoubleClick { get; set; }
        public Nullable<bool> SLC_enableAddRow { get; set; }
        public Nullable<bool> SLC_enableCellNavigation { get; set; }
        public Nullable<bool> SLC_enableCellRangeSelection { get; set; }
        public Nullable<bool> SLC_enableColumnReorder { get; set; }
        public Nullable<bool> SLC_forceFitColumns { get; set; }
        public Nullable<bool> SLC_leaveSpaceForNewRows { get; set; }
        public Nullable<bool> SLC_manualScrolling { get; set; }
        public Nullable<bool> SLC_multiSelect { get; set; }
        public Nullable<bool> SLC_rerenderOnResize { get; set; }
        public Nullable<bool> SLC_secondaryHeaderRowHeight { get; set; }
    
        public virtual T_Slicklist T_Slicklist { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_Slickcolumn_Custom> T_ZO_Slickcolumn_Custom { get; set; }
    }
}

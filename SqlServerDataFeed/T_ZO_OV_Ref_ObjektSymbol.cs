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
    
    public partial class T_ZO_OV_Ref_ObjektSymbol
    {
        public T_ZO_OV_Ref_ObjektSymbol()
        {
            this.T_ZO_OV_Ref_ObjektSymbol_Objekt = new HashSet<T_ZO_OV_Ref_ObjektSymbol_Objekt>();
            this.T_ZO_OV_Ref_ObjektSymbol_T_SYS_Ref_Layerset = new HashSet<T_ZO_OV_Ref_ObjektSymbol_T_SYS_Ref_Layerset>();
        }
    
        public System.Guid OBJS_UID { get; set; }
        public System.Guid OBJS_DK_UID { get; set; }
        public System.Guid OBJS_OBJT_UID { get; set; }
        public int OBJS_MDT_ID { get; set; }
        public int OBJS_Height { get; set; }
        public int OBJS_Width { get; set; }
        public int OBJS_Status { get; set; }
        public int OBJS_Sort { get; set; }
        public string OBJS_Label { get; set; }
        public Nullable<bool> OBJS_ShareSize { get; set; }
        public Nullable<double> OBJS_Width_DWG { get; set; }
        public Nullable<double> OBJS_Height_DWG { get; set; }
        public Nullable<System.Guid> OBJS_OBJT_KAT_UID { get; set; }
        public string OBJS_OBJT_Stamp { get; set; }
    
        public virtual T_AP_Dokumente T_AP_Dokumente { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_OV_Ref_ObjektTyp T_OV_Ref_ObjektTyp { get; set; }
        public virtual ICollection<T_ZO_OV_Ref_ObjektSymbol_Objekt> T_ZO_OV_Ref_ObjektSymbol_Objekt { get; set; }
        public virtual ICollection<T_ZO_OV_Ref_ObjektSymbol_T_SYS_Ref_Layerset> T_ZO_OV_Ref_ObjektSymbol_T_SYS_Ref_Layerset { get; set; }
    }
}

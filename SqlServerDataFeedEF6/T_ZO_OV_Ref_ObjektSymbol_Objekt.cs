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
    
    public partial class T_ZO_OV_Ref_ObjektSymbol_Objekt
    {
        public System.Guid OBJO_UID { get; set; }
        public System.Guid OBJO_OBJS_UID { get; set; }
        public Nullable<System.Guid> OBJO_OBJ_UID { get; set; }
        public int OBJO_MDT_ID { get; set; }
        public double OBJO_Left { get; set; }
        public double OBJO_Top { get; set; }
        public int OBJO_Width { get; set; }
        public int OBJO_Height { get; set; }
        public int OBJO_Angle { get; set; }
        public string OBJO_DWG { get; set; }
        public int OBJO_DistanceX { get; set; }
        public int OBJO_DistanceY { get; set; }
        public double OBJO_CenterX { get; set; }
        public double OBJO_CenterY { get; set; }
        public double OBJO_L { get; set; }
        public double OBJO_R { get; set; }
        public double OBJO_T { get; set; }
        public double OBJO_B { get; set; }
        public int OBJO_Status { get; set; }
        public int OBJO_Sort { get; set; }
        public Nullable<System.Guid> OBJO_VER_UID { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_ZO_OV_Ref_ObjektSymbol T_ZO_OV_Ref_ObjektSymbol { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SqlServerDataFeed
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_ZO_OV_Ref_ObjektText
    {
        public System.Guid ZO_OBJT_UID { get; set; }
        public System.Guid ZO_OBJT_LY_UID { get; set; }
        public int ZO_OBJT_MDT_ID { get; set; }
        public string ZO_OBJT_Text { get; set; }
        public string ZO_OBJT_Font_Family { get; set; }
        public Nullable<int> ZO_OBJT_Font_Size { get; set; }
        public Nullable<int> ZO_OBJT_Font_COL_Aperture { get; set; }
        public Nullable<int> ZO_OBJT_Back_COL_Aperture { get; set; }
        public double ZO_OBJT_Left { get; set; }
        public double ZO_OBJT_Top { get; set; }
        public int ZO_OBJT_Width { get; set; }
        public int ZO_OBJT_Height { get; set; }
        public int ZO_OBJT_Angle { get; set; }
        public string ZO_OBJT_DWG { get; set; }
        public int ZO_OBJT_DistanceX { get; set; }
        public int ZO_OBJT_DistanceY { get; set; }
        public double ZO_OBJT_CenterX { get; set; }
        public double ZO_OBJT_CenterY { get; set; }
        public double ZO_OBJT_L { get; set; }
        public double ZO_OBJT_R { get; set; }
        public double ZO_OBJT_T { get; set; }
        public double ZO_OBJT_B { get; set; }
        public int ZO_OBJT_Status { get; set; }
        public int ZO_OBJT_Sort { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex1 { get; set; }
        public virtual T_SYS_Ref_Layerset T_SYS_Ref_Layerset { get; set; }
    }
}

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
    
    public partial class T_OV_Ref_ObjektTyp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_OV_Ref_ObjektTyp()
        {
            this.T_AP_Ref_DokumentKategorie = new HashSet<T_AP_Ref_DokumentKategorie>();
            this.T_OV_Ref_Attribute_BO = new HashSet<T_OV_Ref_Attribute_BO>();
            this.T_SYS_Form_Feld_Recht = new HashSet<T_SYS_Form_Feld_Recht>();
            this.T_SYS_Form_Register_Recht = new HashSet<T_SYS_Form_Register_Recht>();
            this.T_TM_Tasks_Planung = new HashSet<T_TM_Tasks_Planung>();
            this.T_TM_Tasks = new HashSet<T_TM_Tasks>();
            this.T_ZO_OV_Ref_ObjektSymbol = new HashSet<T_ZO_OV_Ref_ObjektSymbol>();
            this.T_ZO_OV_Ref_Objekttyp_AP_Ref_Mandant = new HashSet<T_ZO_OV_Ref_Objekttyp_AP_Ref_Mandant>();
            this.T_ZO_OV_Ref_Objekttyp_T_SYS_Ref_Register = new HashSet<T_ZO_OV_Ref_Objekttyp_T_SYS_Ref_Register>();
            this.T_ZO_OV_Ref_Objekttyp_TM_Ref_Checkliste = new HashSet<T_ZO_OV_Ref_Objekttyp_TM_Ref_Checkliste>();
            this.T_ZO_SYS_Language_Forms_OV_Ref_ObjektTyp = new HashSet<T_ZO_SYS_Language_Forms_OV_Ref_ObjektTyp>();
        }
    
        public System.Guid OBJT_UID { get; set; }
        public int OBJT_MDT_ID { get; set; }
        public string OBJT_Code { get; set; }
        public string OBJT_Kurz_DE { get; set; }
        public string OBJT_Kurz_FR { get; set; }
        public string OBJT_Kurz_IT { get; set; }
        public string OBJT_Kurz_EN { get; set; }
        public string OBJT_Lang_DE { get; set; }
        public string OBJT_Lang_FR { get; set; }
        public string OBJT_Lang_IT { get; set; }
        public string OBJT_Lang_EN { get; set; }
        public int OBJT_Status { get; set; }
        public int OBJT_Sort { get; set; }
        public Nullable<int> OBJT_StylizerFore { get; set; }
        public Nullable<int> OBJT_StylizerBack { get; set; }
        public Nullable<int> OBJT_StylizerPattern { get; set; }
        public Nullable<int> OBJT_StylizerLine { get; set; }
        public bool OBJT_IsDefault { get; set; }
        public Nullable<System.DateTime> OBJT_DatumMut { get; set; }
        public string OBJT_DatumUser { get; set; }
        public string OBJT_Tabelle { get; set; }
        public string OBJT_FeldPrfx { get; set; }
        public string OBJT_Kat_Tabelle { get; set; }
        public string OBJT_Kat_FeldPrfx { get; set; }
        public bool OBJT_IsApertureObjekt { get; set; }
        public bool OBJT_IsOvObjekt { get; set; }
        public string OBJT_copyView { get; set; }
        public Nullable<int> OBJT_AutoNr { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_AP_Ref_DokumentKategorie> T_AP_Ref_DokumentKategorie { get; set; }
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_OV_Ref_Attribute_BO> T_OV_Ref_Attribute_BO { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_SYS_Form_Feld_Recht> T_SYS_Form_Feld_Recht { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_SYS_Form_Register_Recht> T_SYS_Form_Register_Recht { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TM_Tasks_Planung> T_TM_Tasks_Planung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TM_Tasks> T_TM_Tasks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_OV_Ref_ObjektSymbol> T_ZO_OV_Ref_ObjektSymbol { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_OV_Ref_Objekttyp_AP_Ref_Mandant> T_ZO_OV_Ref_Objekttyp_AP_Ref_Mandant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_OV_Ref_Objekttyp_T_SYS_Ref_Register> T_ZO_OV_Ref_Objekttyp_T_SYS_Ref_Register { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_OV_Ref_Objekttyp_TM_Ref_Checkliste> T_ZO_OV_Ref_Objekttyp_TM_Ref_Checkliste { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_SYS_Language_Forms_OV_Ref_ObjektTyp> T_ZO_SYS_Language_Forms_OV_Ref_ObjektTyp { get; set; }
    }
}

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
    
    public partial class T_REM_Ref_Vorlagen
    {
        public System.Guid REMVO_UID { get; set; }
        public System.Guid REMVO_REMRA_UID { get; set; }
        public System.Guid REMVO_REMAG_UID { get; set; }
        public System.Guid REMVO_REMIN_UID { get; set; }
        public System.Guid REMVO_REMAT_UID { get; set; }
        public Nullable<System.Guid> REMVO_REMAL_UID { get; set; }
        public Nullable<double> REMVO_REMAL_Eingabe { get; set; }
        public int REMVO_Code { get; set; }
        public string REMVO_Kurz_de { get; set; }
        public string REMVO_Kurz_fr { get; set; }
        public string REMVO_Kurz_it { get; set; }
        public string REMVO_Kurz_en { get; set; }
        public string REMVO_Lang_de { get; set; }
        public string REMVO_Lang_fr { get; set; }
        public string REMVO_Lang_it { get; set; }
        public string REMVO_Lang_en { get; set; }
        public int REMVO_Status { get; set; }
        public int REMVO_Sort { get; set; }
        public bool REMVO_IsDefault { get; set; }
        public Nullable<int> REMVO_StylizerBack { get; set; }
        public Nullable<int> REMVO_StylizerFore { get; set; }
        public Nullable<int> REMVO_StylizerPattern { get; set; }
        public Nullable<int> REMVO_StylizerLine { get; set; }
        public Nullable<System.Guid> REMVO_RP_UID { get; set; }
        public Nullable<System.Guid> REMVO_BB_UID { get; set; }
        public Nullable<System.Guid> REMVO_NA_UID { get; set; }
        public Nullable<System.Guid> REMVO_SO_UID { get; set; }
    
        public virtual T_AP_Ref_Bodenbelag T_AP_Ref_Bodenbelag { get; set; }
        public virtual T_AP_Ref_Nutzungsart T_AP_Ref_Nutzungsart { get; set; }
        public virtual T_AP_Ref_Reinigungsprio T_AP_Ref_Reinigungsprio { get; set; }
        public virtual T_AP_Standort T_AP_Standort { get; set; }
        public virtual T_REM_Ref_AnzahlTag T_REM_Ref_AnzahlTag { get; set; }
        public virtual T_REM_Ref_Arbeitsgang T_REM_Ref_Arbeitsgang { get; set; }
        public virtual T_REM_Ref_Arbeitsgang_Leistung T_REM_Ref_Arbeitsgang_Leistung { get; set; }
        public virtual T_REM_Ref_Intervall T_REM_Ref_Intervall { get; set; }
        public virtual T_REM_Ref_Reinigungsart T_REM_Ref_Reinigungsart { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
    }
}

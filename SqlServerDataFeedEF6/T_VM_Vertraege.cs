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
    
    public partial class T_VM_Vertraege
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_VM_Vertraege()
        {
            this.T_TM_Tasks = new HashSet<T_TM_Tasks>();
            this.T_TM_Tasks_Planung = new HashSet<T_TM_Tasks_Planung>();
            this.T_VM_Vertraege_History = new HashSet<T_VM_Vertraege_History>();
            this.T_ZO_AP_Aussenobjekt_AP_Belegung = new HashSet<T_ZO_AP_Aussenobjekt_AP_Belegung>();
            this.T_ZO_AP_Aussenobjekt_AP_Ref_Anmietvertraege = new HashSet<T_ZO_AP_Aussenobjekt_AP_Ref_Anmietvertraege>();
            this.T_ZO_AP_Aussenobjekt_AP_Ref_Mietvertraege = new HashSet<T_ZO_AP_Aussenobjekt_AP_Ref_Mietvertraege>();
            this.T_ZO_AP_Objekt_AP_Vertrag = new HashSet<T_ZO_AP_Objekt_AP_Vertrag>();
            this.T_ZO_AP_Parkplatz_AP_Belegung = new HashSet<T_ZO_AP_Parkplatz_AP_Belegung>();
            this.T_ZO_AP_Parkplatz_AP_Ref_Anmietvertraege = new HashSet<T_ZO_AP_Parkplatz_AP_Ref_Anmietvertraege>();
            this.T_ZO_AP_Parkplatz_AP_Ref_Mietvertraege = new HashSet<T_ZO_AP_Parkplatz_AP_Ref_Mietvertraege>();
            this.T_ZO_AP_Raum_AP_Ref_Anmietvertraege = new HashSet<T_ZO_AP_Raum_AP_Ref_Anmietvertraege>();
            this.T_ZO_AP_Raum_AP_Ref_Mietvertraege = new HashSet<T_ZO_AP_Raum_AP_Ref_Mietvertraege>();
            this.T_ZO_AP_Zone_AP_Ref_Anmietvertraege = new HashSet<T_ZO_AP_Zone_AP_Ref_Anmietvertraege>();
            this.T_ZO_AP_Zone_AP_Ref_Mietvertraege = new HashSet<T_ZO_AP_Zone_AP_Ref_Mietvertraege>();
        }
    
        public System.Guid VTR_UID { get; set; }
        public int VTR_MDT_ID { get; set; }
        public Nullable<System.Guid> VTR_VTP_UID { get; set; }
        public string VTR_Nr { get; set; }
        public Nullable<System.Guid> VTR_VT_UID { get; set; }
        public Nullable<System.Guid> VTR_KT_UID { get; set; }
        public string VTR_Bezeichnung { get; set; }
        public string VTR_Bemerkung { get; set; }
        public Nullable<System.DateTime> VTR_Datum { get; set; }
        public Nullable<System.DateTime> VTR_Startdatum { get; set; }
        public Nullable<System.DateTime> VTR_Ablaufdatum { get; set; }
        public Nullable<int> VTR_Kuendigungsfrist { get; set; }
        public Nullable<System.DateTime> VTR_Kundigungsdatum { get; set; }
        public bool VTR_IsAutoVerlaengerung { get; set; }
        public Nullable<System.Guid> VTR_ADR_UID { get; set; }
        public Nullable<System.Guid> VTR_AKP_UID { get; set; }
        public string VTR_Stoerung { get; set; }
        public System.DateTime VTR_WartungLetzte { get; set; }
        public string VTR_WartungTaetigkeit { get; set; }
        public System.DateTime VTR_WartungNaechste { get; set; }
        public int VTR_WartungAbstand { get; set; }
        public Nullable<double> VTR_Mietzins { get; set; }
        public Nullable<double> VTR_Mietflaeche { get; set; }
        public Nullable<double> VTR_Nebenkosten { get; set; }
        public string VTR_Mietobjekt { get; set; }
        public Nullable<double> VTR_Kosten { get; set; }
        public Nullable<System.Guid> VTR_KP_UID { get; set; }
        public Nullable<int> VTR_Laufzeit { get; set; }
        public Nullable<System.Guid> VTR_ZYP_UID_Laufzeit { get; set; }
        public Nullable<int> VTR_Verlaengerung { get; set; }
        public Nullable<System.Guid> VTR_ZYP_UID_Verlaengerung { get; set; }
        public Nullable<int> VTR_BE_ID_verantwortlich { get; set; }
        public Nullable<System.Guid> VTR_VZ_UID { get; set; }
        public Nullable<int> VTR_StylizerFore { get; set; }
        public Nullable<int> VTR_StylizerBack { get; set; }
        public Nullable<int> VTR_StylizerPattern { get; set; }
        public Nullable<int> VTR_StylizerLine { get; set; }
        public Nullable<int> VTR_Status { get; set; }
        public Nullable<System.DateTime> VTR_SNB_FruehsterKuendigungstermin { get; set; }
        public Nullable<System.DateTime> VTR_LetzteVertragsaenderung { get; set; }
        public string VTR_SNB_KuendigungMoeglichPer { get; set; }
    
        public virtual T_AP_Ref_Mandant T_AP_Ref_Mandant { get; set; }
        public virtual T_AV_AdresseKontaktpersonen T_AV_AdresseKontaktpersonen { get; set; }
        public virtual T_AV_Adressen T_AV_Adressen { get; set; }
        public virtual T_SYS_ApertureColorToHex T_SYS_ApertureColorToHex { get; set; }
        public virtual T_TM_Ref_ZyklusPeriode T_TM_Ref_ZyklusPeriode { get; set; }
        public virtual T_TM_Ref_ZyklusPeriode T_TM_Ref_ZyklusPeriode1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TM_Tasks> T_TM_Tasks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TM_Tasks_Planung> T_TM_Tasks_Planung { get; set; }
        public virtual T_VM_Ref_KostenPeriode T_VM_Ref_KostenPeriode { get; set; }
        public virtual T_VM_Ref_Vertragspartei T_VM_Ref_Vertragspartei { get; set; }
        public virtual T_VM_Ref_Vertragstyp T_VM_Ref_Vertragstyp { get; set; }
        public virtual T_VM_Ref_Vertragszustaendigkeit T_VM_Ref_Vertragszustaendigkeit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_VM_Vertraege_History> T_VM_Vertraege_History { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Aussenobjekt_AP_Belegung> T_ZO_AP_Aussenobjekt_AP_Belegung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Aussenobjekt_AP_Ref_Anmietvertraege> T_ZO_AP_Aussenobjekt_AP_Ref_Anmietvertraege { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Aussenobjekt_AP_Ref_Mietvertraege> T_ZO_AP_Aussenobjekt_AP_Ref_Mietvertraege { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Objekt_AP_Vertrag> T_ZO_AP_Objekt_AP_Vertrag { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Parkplatz_AP_Belegung> T_ZO_AP_Parkplatz_AP_Belegung { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Parkplatz_AP_Ref_Anmietvertraege> T_ZO_AP_Parkplatz_AP_Ref_Anmietvertraege { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Parkplatz_AP_Ref_Mietvertraege> T_ZO_AP_Parkplatz_AP_Ref_Mietvertraege { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Raum_AP_Ref_Anmietvertraege> T_ZO_AP_Raum_AP_Ref_Anmietvertraege { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Raum_AP_Ref_Mietvertraege> T_ZO_AP_Raum_AP_Ref_Mietvertraege { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Zone_AP_Ref_Anmietvertraege> T_ZO_AP_Zone_AP_Ref_Anmietvertraege { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ZO_AP_Zone_AP_Ref_Mietvertraege> T_ZO_AP_Zone_AP_Ref_Mietvertraege { get; set; }
    }
}

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
    
    public partial class T_SYS_Language
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_SYS_Language()
        {
            this.T_SYS_Language_Forms_i18n_Cust = new HashSet<T_SYS_Language_Forms_i18n_Cust>();
            this.T_SYS_Language_Forms_i18n = new HashSet<T_SYS_Language_Forms_i18n>();
        }
    
        public int SYSLANG_LCID { get; set; }
        public string SYSLANG_CultureName { get; set; }
        public string SYSLANG_Name { get; set; }
        public string SYSLANG_IetfLanguageTag { get; set; }
        public string SYSLANG_TwoLetterISOLanguageName { get; set; }
        public string SYSLANG_ThreeLetterISOLanguageName { get; set; }
        public string SYSLANG_ThreeLetterWindowsLanguageName { get; set; }
        public string SYSLANG_EnglishName { get; set; }
        public string SYSLANG_NativeName { get; set; }
        public string SYSLANG_DisplayName { get; set; }
        public string SYSLANG_NativeCalendarName { get; set; }
        public string SYSLANG_FullDateTimePattern { get; set; }
        public string SYSLANG_RFC1123Pattern { get; set; }
        public string SYSLANG_SortableDateTimePattern { get; set; }
        public string SYSLANG_UniversalSortableDateTimePattern { get; set; }
        public string SYSLANG_DateSeparator { get; set; }
        public string SYSLANG_LongDatePattern { get; set; }
        public string SYSLANG_ShortDatePattern { get; set; }
        public string SYSLANG_LongTimePattern { get; set; }
        public string SYSLANG_ShortTimePattern { get; set; }
        public string SYSLANG_YearMonthPattern { get; set; }
        public string SYSLANG_MonthDayPattern { get; set; }
        public string SYSLANG_PMDesignator { get; set; }
        public string SYSLANG_AMDesignator { get; set; }
        public string SYSLANG_Calendar { get; set; }
        public Nullable<bool> SYSLANG_IsNeutralCulture { get; set; }
        public Nullable<bool> SYSLANG_IsRightToLeft { get; set; }
        public Nullable<int> SYSLANG_ParentLCID { get; set; }
        public Nullable<int> SYSLANG_ANSICodePage { get; set; }
        public Nullable<int> SYSLANG_EBCDICCodePage { get; set; }
        public Nullable<int> SYSLANG_MacCodePage { get; set; }
        public Nullable<int> SYSLANG_OEMCodePage { get; set; }
        public string SYSLANG_ListSeparator { get; set; }
        public string SYSLANG_NumberDecimalSeparator { get; set; }
        public string SYSLANG_NumberGroupSeparator { get; set; }
        public string SYSLANG_NumberNegativePattern { get; set; }
        public string SYSLANG_CurrencyDecimalSeparator { get; set; }
        public string SYSLANG_CurrencyGroupSeparator { get; set; }
        public string SYSLANG_CurrencySymbol { get; set; }
        public string SYSLANG_CurrencyNegativePattern { get; set; }
        public string SYSLANG_CurrencyPositivePattern { get; set; }
        public string SYSLANG_PercentDecimalSeparator { get; set; }
        public string SYSLANG_PercentGroupSeparator { get; set; }
        public string SYSLANG_PercentNegativePattern { get; set; }
        public string SYSLANG_PercentPositivePattern { get; set; }
        public Nullable<bool> SYSLANG_CorUse { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_SYS_Language_Forms_i18n_Cust> T_SYS_Language_Forms_i18n_Cust { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_SYS_Language_Forms_i18n> T_SYS_Language_Forms_i18n { get; set; }
    }
}

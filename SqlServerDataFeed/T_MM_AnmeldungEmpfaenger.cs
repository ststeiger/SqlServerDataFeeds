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
    
    public partial class T_MM_AnmeldungEmpfaenger
    {
        public System.Guid MMAE_UID { get; set; }
        public string MMAE_Mailbox { get; set; }
        public string MMAE_Definiert { get; set; }
        public bool MMAE_IsDefiniert { get; set; }
        public bool MMAE_IsMailbox { get; set; }
        public bool MMAE_IsEmpfaengerAn { get; set; }
        public bool MMAE_IsEmpfaengerCC { get; set; }
        public int MMAE_Status { get; set; }
    }
}

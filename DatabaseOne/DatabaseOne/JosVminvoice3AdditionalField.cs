using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVminvoice3AdditionalField
    {
        public int Id { get; set; }
        public string BankName { get; set; }
        public string AccountNr { get; set; }
        public string BankCodeNo { get; set; }
        public string BicSwift { get; set; }
        public string Iban { get; set; }
        public string TaxNumber { get; set; }
        public string VatId { get; set; }
        public string RegistrationCourt { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string WebUrl { get; set; }
        public string NoteStart { get; set; }
        public string NoteEnd { get; set; }
        public int ShowBankName { get; set; }
        public int ShowAccountNr { get; set; }
        public int ShowBankCodeNo { get; set; }
        public int ShowBicSwift { get; set; }
        public int ShowIban { get; set; }
        public int ShowVatId { get; set; }
        public int ShowTaxNumber { get; set; }
        public int ShowRegistrationCourt { get; set; }
        public int ShowPhone { get; set; }
        public int ShowEmail { get; set; }
        public int ShowWebUrl { get; set; }
        public int? LastFieldsChange { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosVirtuemartCurrency
    {
        public ushort VirtuemartCurrencyId { get; set; }
        public ushort VirtuemartVendorId { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyCode2 { get; set; }
        public string CurrencyCode3 { get; set; }
        public int? CurrencyNumericCode { get; set; }
        public decimal? CurrencyExchangeRate { get; set; }
        public string CurrencySymbol { get; set; }
        public string CurrencyDecimalPlace { get; set; }
        public string CurrencyDecimalSymbol { get; set; }
        public string CurrencyThousands { get; set; }
        public string CurrencyPositiveStyle { get; set; }
        public string CurrencyNegativeStyle { get; set; }
        public int Ordering { get; set; }
        public bool? Shared { get; set; }
        public bool? Published { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}

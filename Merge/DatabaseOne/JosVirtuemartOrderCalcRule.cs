using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosVirtuemartOrderCalcRule
    {
        public uint VirtuemartOrderCalcRuleId { get; set; }
        public int? VirtuemartCalcId { get; set; }
        public int? VirtuemartOrderId { get; set; }
        public short VirtuemartVendorId { get; set; }
        public int? VirtuemartOrderItemId { get; set; }
        public string CalcRuleName { get; set; }
        public string CalcKind { get; set; }
        public string CalcMathop { get; set; }
        public decimal CalcAmount { get; set; }
        public decimal CalcResult { get; set; }
        public decimal CalcValue { get; set; }
        public short? CalcCurrency { get; set; }
        public string CalcParams { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}

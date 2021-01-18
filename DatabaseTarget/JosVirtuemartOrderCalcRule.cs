using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosVirtuemartOrderCalcRule
    {
        public uint VirtuemartOrderCalcRuleId { get; set; }
        public uint? VirtuemartCalcId { get; set; }
        public uint? VirtuemartOrderId { get; set; }
        public uint VirtuemartVendorId { get; set; }
        public int? VirtuemartOrderItemId { get; set; }
        public string CalcRuleName { get; set; }
        public string CalcKind { get; set; }
        public string CalcMathop { get; set; }
        public decimal CalcAmount { get; set; }
        public decimal CalcResult { get; set; }
        public decimal CalcValue { get; set; }
        public int? CalcCurrency { get; set; }
        public string CalcParams { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}

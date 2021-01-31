using System;
using System.Collections.Generic;
using DatabaseTwo.Extensions;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartCalc : EntityUtilities
    {
        public int VirtuemartCalcId { get; set; }
        public int VirtuemartVendorId { get; set; }
        public int CalcJpluginId { get; set; }
        public string CalcName { get; set; }
        public string CalcDescr { get; set; }
        public string CalcKind { get; set; }
        public string CalcValueMathop { get; set; }
        public decimal CalcValue { get; set; }
        public int CalcCurrency { get; set; }
        public int CalcShopperPublished { get; set; }
        public int CalcVendorPublished { get; set; }
        public DateTime PublishUp { get; set; }
        public DateTime PublishDown { get; set; }
        public int ForOverride { get; set; }
        public string CalcParams { get; set; }
        public int Ordering { get; set; }
        public int Shared { get; set; }
        public int? Published { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}

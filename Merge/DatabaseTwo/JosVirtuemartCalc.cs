﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseTwo
{
    public partial class JosVirtuemartCalc
    {
        public ushort VirtuemartCalcId { get; set; }
        public ushort VirtuemartVendorId { get; set; }
        public int CalcJpluginId { get; set; }
        public string CalcName { get; set; }
        public string CalcDescr { get; set; }
        public string CalcKind { get; set; }
        public string CalcValueMathop { get; set; }
        public decimal CalcValue { get; set; }
        public ushort CalcCurrency { get; set; }
        public bool CalcShopperPublished { get; set; }
        public bool CalcVendorPublished { get; set; }
        public DateTime PublishUp { get; set; }
        public DateTime PublishDown { get; set; }
        public bool ForOverride { get; set; }
        public string CalcParams { get; set; }
        public int Ordering { get; set; }
        public bool Shared { get; set; }
        public bool? Published { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}

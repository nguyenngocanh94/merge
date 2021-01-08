﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseTwo
{
    public partial class JosVirtuemartCoupon
    {
        public uint VirtuemartCouponId { get; set; }
        public string CouponUsed { get; set; }
        public string CouponCode { get; set; }
        public string PercentOrTotal { get; set; }
        public string CouponType { get; set; }
        public decimal CouponValue { get; set; }
        public DateTime? CouponStartDate { get; set; }
        public DateTime? CouponExpiryDate { get; set; }
        public decimal CouponValueValid { get; set; }
        public bool? Published { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}

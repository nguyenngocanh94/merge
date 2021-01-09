using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosAwocouponVm
    {
        public int Id { get; set; }
        public string CouponCode { get; set; }
        public int NumOfUses { get; set; }
        public string CouponValueType { get; set; }
        public decimal CouponValue { get; set; }
        public decimal? MinValue { get; set; }
        public string DiscountType { get; set; }
        public string FunctionType { get; set; }
        public string FunctionType2 { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Expiration { get; set; }
        public sbyte Published { get; set; }
    }
}

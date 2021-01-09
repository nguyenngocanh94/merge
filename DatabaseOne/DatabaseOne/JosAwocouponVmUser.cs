using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosAwocouponVmUser
    {
        public int Id { get; set; }
        public string CouponId { get; set; }
        public int UserId { get; set; }
    }
}

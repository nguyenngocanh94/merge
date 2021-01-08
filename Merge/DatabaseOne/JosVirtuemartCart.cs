using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosVirtuemartCart
    {
        public uint VirtuemartCartId { get; set; }
        public uint VirtuemartUserId { get; set; }
        public uint VirtuemartVendorId { get; set; }
        public byte[] CartData { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
    }
}

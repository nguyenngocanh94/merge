using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseTwo
{
    public partial class JosVirtuemartVendorUser
    {
        public ushort Id { get; set; }
        public ushort VirtuemartVendorId { get; set; }
        public uint VirtuemartUserId { get; set; }
    }
}

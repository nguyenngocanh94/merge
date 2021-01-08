using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosVirtuemartVendorUser
    {
        public ushort Id { get; set; }
        public ushort VirtuemartVendorId { get; set; }
        public uint VirtuemartUserId { get; set; }
    }
}

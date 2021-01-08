using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosVirtuemartVendorMedia
    {
        public ushort Id { get; set; }
        public ushort VirtuemartVendorId { get; set; }
        public uint VirtuemartMediaId { get; set; }
        public int Ordering { get; set; }
    }
}

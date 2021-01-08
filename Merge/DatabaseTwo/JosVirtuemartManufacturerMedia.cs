using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseTwo
{
    public partial class JosVirtuemartManufacturerMedia
    {
        public uint Id { get; set; }
        public ushort VirtuemartManufacturerId { get; set; }
        public uint VirtuemartMediaId { get; set; }
        public int Ordering { get; set; }
    }
}

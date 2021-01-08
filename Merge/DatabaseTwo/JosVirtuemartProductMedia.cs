using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseTwo
{
    public partial class JosVirtuemartProductMedia
    {
        public uint Id { get; set; }
        public uint VirtuemartProductId { get; set; }
        public uint VirtuemartMediaId { get; set; }
        public int Ordering { get; set; }
    }
}

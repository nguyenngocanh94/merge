using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseTwo
{
    public partial class JosVirtuemartCategoryMedia
    {
        public uint Id { get; set; }
        public uint VirtuemartCategoryId { get; set; }
        public uint VirtuemartMediaId { get; set; }
        public int Ordering { get; set; }
    }
}

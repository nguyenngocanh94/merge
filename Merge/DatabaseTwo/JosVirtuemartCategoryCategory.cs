using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseTwo
{
    public partial class JosVirtuemartCategoryCategory
    {
        public uint Id { get; set; }
        public uint CategoryParentId { get; set; }
        public uint CategoryChildId { get; set; }
        public int Ordering { get; set; }
    }
}

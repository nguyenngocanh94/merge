using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosVirtuemartProductCategory
    {
        public uint Id { get; set; }
        public uint VirtuemartProductId { get; set; }
        public uint VirtuemartCategoryId { get; set; }
        public int Ordering { get; set; }
    }
}

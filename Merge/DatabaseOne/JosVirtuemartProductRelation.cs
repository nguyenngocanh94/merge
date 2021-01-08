using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosVirtuemartProductRelation
    {
        public uint Id { get; set; }
        public uint VirtuemartProductId { get; set; }
        public int? RelatedProducts { get; set; }
    }
}

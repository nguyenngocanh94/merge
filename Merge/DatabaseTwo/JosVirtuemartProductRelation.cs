using System;
using System.Collections.Generic;
using Merge.Extensions;

#nullable disable

namespace Merge.DatabaseTwo
{
    public partial class JosVirtuemartProductRelation : EntityUtilities
    {
        public int Id { get; set; }
        public int VirtuemartProductId { get; set; }
        public int? RelatedProducts { get; set; }
    }
}

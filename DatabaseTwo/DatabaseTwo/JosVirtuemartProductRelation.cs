using System;
using System.Collections.Generic;
using DatabaseTwo.Extensions;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartProductRelation : EntityUtilities
    {
        public int Id { get; set; }
        public int VirtuemartProductId { get; set; }
        public int? RelatedProducts { get; set; }
    }
}

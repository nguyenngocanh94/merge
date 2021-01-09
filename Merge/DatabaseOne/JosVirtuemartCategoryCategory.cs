using System;
using System.Collections.Generic;
using Merge.Extensions;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosVirtuemartCategoryCategory : EntityUtilities
    {
        public int Id { get; set; }
        public int CategoryParentId { get; set; }
        public int CategoryChildId { get; set; }
        public int Ordering { get; set; }
    }
}

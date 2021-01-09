using System;
using System.Collections.Generic;
using Merge.Extensions;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosVirtuemartCalcCategory : EntityUtilities
    {
        public int Id { get; set; }
        public int VirtuemartCalcId { get; set; }
        public int VirtuemartCategoryId { get; set; }
    }
}

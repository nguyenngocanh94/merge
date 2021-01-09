using System;
using System.Collections.Generic;
using DatabaseTwo.Extensions;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartCategoryCategory : EntityUtilities
    {
        public int Id { get; set; }
        public int CategoryParentId { get; set; }
        public int CategoryChildId { get; set; }
        public int Ordering { get; set; }
    }
}

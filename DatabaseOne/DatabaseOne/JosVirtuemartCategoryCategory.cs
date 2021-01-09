using System;
using DatabaseOne.Extensions;


#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartCategoryCategory : EntityUtilities
    {
        public int Id { get; set; }
        public int CategoryParentId { get; set; }
        public int CategoryChildId { get; set; }
        public int Ordering { get; set; }
    }
}

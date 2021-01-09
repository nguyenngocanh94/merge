using System;
using System.Collections.Generic;
using DatabaseTwo.Extensions;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartCalcCategory : EntityUtilities
    {
        public int Id { get; set; }
        public int VirtuemartCalcId { get; set; }
        public int VirtuemartCategoryId { get; set; }
    }
}

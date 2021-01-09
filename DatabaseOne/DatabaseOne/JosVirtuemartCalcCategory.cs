using System;
using DatabaseOne.Extensions;


#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartCalcCategory : EntityUtilities
    {
        public int Id { get; set; }
        public int VirtuemartCalcId { get; set; }
        public int VirtuemartCategoryId { get; set; }
    }
}

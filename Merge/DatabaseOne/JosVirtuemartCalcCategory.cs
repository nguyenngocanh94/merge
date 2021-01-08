using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosVirtuemartCalcCategory
    {
        public uint Id { get; set; }
        public ushort VirtuemartCalcId { get; set; }
        public uint VirtuemartCategoryId { get; set; }
    }
}

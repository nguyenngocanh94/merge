using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosVirtuemartCalcManufacturer
    {
        public uint Id { get; set; }
        public ushort VirtuemartCalcId { get; set; }
        public ushort VirtuemartManufacturerId { get; set; }
    }
}

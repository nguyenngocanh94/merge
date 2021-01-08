using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosVirtuemartProductManufacturer
    {
        public uint Id { get; set; }
        public int? VirtuemartProductId { get; set; }
        public ushort? VirtuemartManufacturerId { get; set; }
    }
}

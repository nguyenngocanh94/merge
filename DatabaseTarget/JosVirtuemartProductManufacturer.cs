using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosVirtuemartProductManufacturer
    {
        public uint Id { get; set; }
        public int? VirtuemartProductId { get; set; }
        public uint? VirtuemartManufacturerId { get; set; }
    }
}

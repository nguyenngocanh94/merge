using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartProductManufacturer
    {
        public int Id { get; set; }
        public int? VirtuemartProductId { get; set; }
        public int? VirtuemartManufacturerId { get; set; }
    }
}

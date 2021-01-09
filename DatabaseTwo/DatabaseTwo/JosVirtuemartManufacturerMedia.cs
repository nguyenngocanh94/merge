using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartManufacturerMedia
    {
        public int Id { get; set; }
        public int VirtuemartManufacturerId { get; set; }
        public int VirtuemartMediaId { get; set; }
        public int Ordering { get; set; }
    }
}

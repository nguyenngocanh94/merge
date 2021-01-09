using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartProductManufacturer
    {
        public int Id { get; set; }
        public int? VirtuemartProductId { get; set; }
        public ushort? VirtuemartManufacturerId { get; set; }
    }
}

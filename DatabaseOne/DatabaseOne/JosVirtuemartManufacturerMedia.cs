using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartManufacturerMedia
    {
        public int Id { get; set; }
        public ushort VirtuemartManufacturerId { get; set; }
        public int VirtuemartMediaId { get; set; }
        public int Ordering { get; set; }
    }
}

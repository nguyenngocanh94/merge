using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartCalcManufacturer
    {
        public int Id { get; set; }
        public ushort VirtuemartCalcId { get; set; }
        public ushort VirtuemartManufacturerId { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosVirtuemartMigrationOldtonewId
    {
        public byte[] Attributes { get; set; }
        public byte[] Relatedproducts { get; set; }
        public ushort Id { get; set; }
        public byte[] Cats { get; set; }
        public byte[] Catsxref { get; set; }
        public byte[] Manus { get; set; }
        public byte[] Mfcats { get; set; }
        public byte[] Shoppergroups { get; set; }
        public byte[] Products { get; set; }
        public int? ProductsStart { get; set; }
        public byte[] Orderstates { get; set; }
        public byte[] Orders { get; set; }
        public int? OrdersStart { get; set; }
    }
}

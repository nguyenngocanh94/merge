using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartProductShoppergroup
    {
        public int Id { get; set; }
        public int VirtuemartProductId { get; set; }
        public ushort VirtuemartShoppergroupId { get; set; }
    }
}

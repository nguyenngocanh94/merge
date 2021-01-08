using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseTwo
{
    public partial class JosVirtuemartVmuserShoppergroup
    {
        public uint Id { get; set; }
        public uint VirtuemartUserId { get; set; }
        public ushort VirtuemartShoppergroupId { get; set; }
    }
}

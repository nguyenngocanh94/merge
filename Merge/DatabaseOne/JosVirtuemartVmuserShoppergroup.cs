using System;
using System.Collections.Generic;
using Merge.Extensions;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosVirtuemartVmuserShoppergroup : EntityUtilities
    {
        public int Id { get; set; }
        public int VirtuemartUserId { get; set; }
        public int VirtuemartShoppergroupId { get; set; }
    }
}

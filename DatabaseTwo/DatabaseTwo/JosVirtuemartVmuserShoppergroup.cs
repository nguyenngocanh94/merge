using System;
using System.Collections.Generic;
using DatabaseTwo.Extensions;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartVmuserShoppergroup : EntityUtilities
    {
        public int Id { get; set; }
        public int VirtuemartUserId { get; set; }
        public int VirtuemartShoppergroupId { get; set; }
    }
}

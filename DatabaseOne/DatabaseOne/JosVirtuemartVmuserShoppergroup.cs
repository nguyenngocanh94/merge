using System;
using DatabaseOne.Extensions;


#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartVmuserShoppergroup : EntityUtilities
    {
        public int Id { get; set; }
        public int VirtuemartUserId { get; set; }
        public int VirtuemartShoppergroupId { get; set; }
    }
}

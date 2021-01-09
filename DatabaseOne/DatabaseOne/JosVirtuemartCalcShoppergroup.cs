using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartCalcShoppergroup
    {
        public int Id { get; set; }
        public ushort VirtuemartCalcId { get; set; }
        public ushort VirtuemartShoppergroupId { get; set; }
    }
}

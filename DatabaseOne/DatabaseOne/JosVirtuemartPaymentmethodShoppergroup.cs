using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartPaymentmethodShoppergroup
    {
        public int Id { get; set; }
        public int VirtuemartPaymentmethodId { get; set; }
        public ushort VirtuemartShoppergroupId { get; set; }
    }
}

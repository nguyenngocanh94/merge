using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartVendorUser
    {
        public ushort Id { get; set; }
        public ushort VirtuemartVendorId { get; set; }
        public int VirtuemartUserId { get; set; }
    }
}

using System;
using DatabaseOne.Extensions;


#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartVendorMedia : EntityUtilities
    {
        public ushort Id { get; set; }
        public ushort VirtuemartVendorId { get; set; }
        public int VirtuemartMediaId { get; set; }
        public int Ordering { get; set; }
    }
}

using System;
using DatabaseOne.Extensions;


#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartCart : EntityUtilities
    {
        public int VirtuemartCartId { get; set; }
        public int VirtuemartUserId { get; set; }
        public int VirtuemartVendorId { get; set; }
        public byte[] CartData { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
    }
}

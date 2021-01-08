using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseTwo
{
    public partial class JosVirtuemartInvoice
    {
        public uint VirtuemartInvoiceId { get; set; }
        public ushort VirtuemartVendorId { get; set; }
        public uint? VirtuemartOrderId { get; set; }
        public string InvoiceNumber { get; set; }
        public string OrderStatus { get; set; }
        public string Xhtml { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}

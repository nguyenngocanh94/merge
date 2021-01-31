using System;
using DatabaseOne.Extensions;


#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartVmuser : EntityUtilities
    {
        public int VirtuemartUserId { get; set; }
        public ushort VirtuemartVendorId { get; set; }
        public int UserIsVendor { get; set; }
        public string CustomerNumber { get; set; }
        public string Perms { get; set; }
        public int? VirtuemartPaymentmethodId { get; set; }
        public int? VirtuemartShipmentmethodId { get; set; }
        public int Agreed { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}

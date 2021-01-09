using System;
using System.Collections.Generic;
using DatabaseTwo.Extensions;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartVmuser : EntityUtilities
    {
        public int VirtuemartUserId { get; set; }
        public int VirtuemartVendorId { get; set; }
        public bool UserIsVendor { get; set; }
        public string CustomerNumber { get; set; }
        public string Perms { get; set; }
        public int? VirtuemartPaymentmethodId { get; set; }
        public int? VirtuemartShipmentmethodId { get; set; }
        public bool Agreed { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}

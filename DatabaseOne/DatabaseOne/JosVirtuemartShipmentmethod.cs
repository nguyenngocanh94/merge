using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartShipmentmethod
    {
        public int VirtuemartShipmentmethodId { get; set; }
        public short VirtuemartVendorId { get; set; }
        public int ShipmentJpluginId { get; set; }
        public string Slug { get; set; }
        public string ShipmentElement { get; set; }
        public string ShipmentParams { get; set; }
        public int Ordering { get; set; }
        public int Shared { get; set; }
        public int? Published { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}

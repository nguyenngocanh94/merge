using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartShipmentPlgWeightCountry
    {
        public int Id { get; set; }
        public int? VirtuemartOrderId { get; set; }
        public string OrderNumber { get; set; }
        public int? VirtuemartShipmentmethodId { get; set; }
        public string ShipmentName { get; set; }
        public decimal? OrderWeight { get; set; }
        public string ShipmentWeightUnit { get; set; }
        public decimal? ShipmentCost { get; set; }
        public decimal? ShipmentPackageFee { get; set; }
        public short? TaxId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}

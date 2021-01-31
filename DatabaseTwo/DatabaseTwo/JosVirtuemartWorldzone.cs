using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartWorldzone
    {
        public int VirtuemartWorldzoneId { get; set; }
        public short? VirtuemartVendorId { get; set; }
        public string ZoneName { get; set; }
        public decimal? ZoneCost { get; set; }
        public decimal? ZoneLimit { get; set; }
        public string ZoneDescription { get; set; }
        public int ZoneTaxRate { get; set; }
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

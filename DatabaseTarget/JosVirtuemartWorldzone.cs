using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosVirtuemartWorldzone
    {
        public ushort VirtuemartWorldzoneId { get; set; }
        public uint? VirtuemartVendorId { get; set; }
        public string ZoneName { get; set; }
        public decimal? ZoneCost { get; set; }
        public decimal? ZoneLimit { get; set; }
        public string ZoneDescription { get; set; }
        public uint ZoneTaxRate { get; set; }
        public int Ordering { get; set; }
        public bool Shared { get; set; }
        public bool? Published { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}

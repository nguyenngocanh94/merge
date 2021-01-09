using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartPermgroup
    {
        public byte VirtuemartPermgroupId { get; set; }
        public ushort VirtuemartVendorId { get; set; }
        public string GroupName { get; set; }
        public int? GroupLevel { get; set; }
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

using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartConfig
    {
        public byte VirtuemartConfigId { get; set; }
        public string Config { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}

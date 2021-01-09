using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartUserfieldValue
    {
        public int VirtuemartUserfieldValueId { get; set; }
        public ushort VirtuemartUserfieldId { get; set; }
        public string Fieldtitle { get; set; }
        public string Fieldvalue { get; set; }
        public sbyte Sys { get; set; }
        public int Ordering { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}

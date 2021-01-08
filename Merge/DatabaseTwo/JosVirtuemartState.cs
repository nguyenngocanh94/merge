using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseTwo
{
    public partial class JosVirtuemartState
    {
        public ushort VirtuemartStateId { get; set; }
        public ushort VirtuemartVendorId { get; set; }
        public ushort VirtuemartCountryId { get; set; }
        public ushort VirtuemartWorldzoneId { get; set; }
        public string StateName { get; set; }
        public string State3Code { get; set; }
        public string State2Code { get; set; }
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

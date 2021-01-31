using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartState
    {
        public int VirtuemartStateId { get; set; }
        public int VirtuemartVendorId { get; set; }
        public int VirtuemartCountryId { get; set; }
        public int VirtuemartWorldzoneId { get; set; }
        public string StateName { get; set; }
        public string State3Code { get; set; }
        public string State2Code { get; set; }
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

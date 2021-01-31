using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartCountry
    {
        public int VirtuemartCountryId { get; set; }
        public int? VirtuemartWorldzoneId { get; set; }
        public string CountryName { get; set; }
        public string Country3Code { get; set; }
        public string Country2Code { get; set; }
        public int Ordering { get; set; }
        public int? Published { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}

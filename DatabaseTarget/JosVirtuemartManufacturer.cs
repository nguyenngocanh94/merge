using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosVirtuemartManufacturer
    {
        public uint VirtuemartManufacturerId { get; set; }
        public int? VirtuemartManufacturercategoriesId { get; set; }
        public string Metarobot { get; set; }
        public string Metaauthor { get; set; }
        public uint Hits { get; set; }
        public bool? Published { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseTwo
{
    public partial class JosVirtuemartUserfield
    {
        public ushort VirtuemartUserfieldId { get; set; }
        public ushort VirtuemartVendorId { get; set; }
        public int UserfieldJpluginId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int? Maxlength { get; set; }
        public int? Size { get; set; }
        public sbyte Required { get; set; }
        public int? Cols { get; set; }
        public int? Rows { get; set; }
        public string Value { get; set; }
        public string Default { get; set; }
        public bool Registration { get; set; }
        public bool Shipment { get; set; }
        public bool? Account { get; set; }
        public bool Cart { get; set; }
        public bool Readonly { get; set; }
        public bool Calculated { get; set; }
        public sbyte Sys { get; set; }
        public string UserfieldParams { get; set; }
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

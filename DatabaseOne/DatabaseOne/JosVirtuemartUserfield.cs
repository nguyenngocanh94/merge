using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
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
        public int Registration { get; set; }
        public int Shipment { get; set; }
        public int? Account { get; set; }
        public int Cart { get; set; }
        public int Readonly { get; set; }
        public int Calculated { get; set; }
        public sbyte Sys { get; set; }
        public string UserfieldParams { get; set; }
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

using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class WjlytVirtuemartCategory
    {
        public ushort VirtuemartCategoryId { get; set; }
        public ushort VirtuemartVendorId { get; set; }
        public string CategoryTemplate { get; set; }
        public string CategoryLayout { get; set; }
        public string CategoryProductLayout { get; set; }
        public sbyte? ProductsPerRow { get; set; }
        public ushort? LimitListStart { get; set; }
        public ushort? LimitListStep { get; set; }
        public ushort? LimitListMax { get; set; }
        public ushort? LimitListInitial { get; set; }
        public uint Hits { get; set; }
        public string Metarobot { get; set; }
        public string Metaauthor { get; set; }
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

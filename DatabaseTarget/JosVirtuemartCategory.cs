using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosVirtuemartCategory
    {
        public uint VirtuemartCategoryId { get; set; }
        public uint? CategoryParentId { get; set; }
        public uint VirtuemartVendorId { get; set; }
        public string CategoryTemplate { get; set; }
        public string CategoryLayout { get; set; }
        public string CategoryProductLayout { get; set; }
        public string ProductsPerRow { get; set; }
        public string LimitListStep { get; set; }
        public ushort? LimitListStart { get; set; }
        public ushort? LimitListMax { get; set; }
        public ushort? LimitListInitial { get; set; }
        public uint Hits { get; set; }
        public string CatParams { get; set; }
        public string Metarobot { get; set; }
        public string Metaauthor { get; set; }
        public int Ordering { get; set; }
        public bool Shared { get; set; }
        public bool? Published { get; set; }
        public bool? HasChildren { get; set; }
        public bool? HasMedias { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}

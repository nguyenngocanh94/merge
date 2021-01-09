using System;
using System.Collections.Generic;
using DatabaseTwo.Extensions;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartCategory : EntityUtilities
    {
        public int VirtuemartCategoryId { get; set; }
        public int VirtuemartVendorId { get; set; }
        public string CategoryTemplate { get; set; }
        public string CategoryLayout { get; set; }
        public string CategoryProductLayout { get; set; }
        public bool? ProductsPerRow { get; set; }
        public int? LimitListStart { get; set; }
        public string LimitListStep { get; set; }
        public int? LimitListMax { get; set; }
        public int? LimitListInitial { get; set; }
        public int Hits { get; set; }
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

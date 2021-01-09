using System;
using System.Collections.Generic;
using Merge.Extensions;

#nullable disable

namespace Merge.DatabaseTwo
{
    public partial class JosVirtuemartProductCustomfield : EntityUtilities
    {
        public int VirtuemartCustomfieldId { get; set; }
        public int VirtuemartProductId { get; set; }
        public int VirtuemartCustomId { get; set; }
        public string CustomfieldValue { get; set; }
        public uint Disabler { get; set; }
        public uint Override { get; set; }
        public string CustomfieldParams { get; set; }
        public decimal? CustomfieldPrice { get; set; }
        public string ProductSku { get; set; }
        public string ProductGtin { get; set; }
        public string ProductMpn { get; set; }
        public bool? Published { get; set; }
        public DateTime CreatedOn { get; set; }
        public uint CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public uint ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public uint LockedBy { get; set; }
        public int Ordering { get; set; }
    }
}

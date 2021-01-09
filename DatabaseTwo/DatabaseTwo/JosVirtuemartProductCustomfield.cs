using System;
using System.Collections.Generic;
using DatabaseTwo.Extensions;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartProductCustomfield : EntityUtilities
    {
        public int VirtuemartCustomfieldId { get; set; }
        public int VirtuemartProductId { get; set; }
        public int VirtuemartCustomId { get; set; }
        public string CustomfieldValue { get; set; }
        public int Disabler { get; set; }
        public int Override { get; set; }
        public string CustomfieldParams { get; set; }
        public decimal? CustomfieldPrice { get; set; }
        public string ProductSku { get; set; }
        public string ProductGtin { get; set; }
        public string ProductMpn { get; set; }
        public bool? Published { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
        public int Ordering { get; set; }
    }
}

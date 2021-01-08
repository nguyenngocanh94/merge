using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseTwo
{
    public partial class JosVirtuemartRating
    {
        public uint VirtuemartRatingId { get; set; }
        public uint VirtuemartProductId { get; set; }
        public int Rates { get; set; }
        public uint Ratingcount { get; set; }
        public decimal Rating { get; set; }
        public bool? Published { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
    }
}

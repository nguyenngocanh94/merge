using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseTwo
{
    public partial class JosVirtuemartRatingReview
    {
        public uint VirtuemartRatingReviewId { get; set; }
        public uint VirtuemartProductId { get; set; }
        public string Comment { get; set; }
        public bool ReviewOk { get; set; }
        public uint ReviewRates { get; set; }
        public uint ReviewRatingcount { get; set; }
        public decimal ReviewRating { get; set; }
        public bool? ReviewEditable { get; set; }
        public string Lastip { get; set; }
        public bool? Published { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}

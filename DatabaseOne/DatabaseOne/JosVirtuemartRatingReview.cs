﻿using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartRatingReview
    {
        public int VirtuemartRatingReviewId { get; set; }
        public int VirtuemartProductId { get; set; }
        public string Comment { get; set; }
        public int ReviewOk { get; set; }
        public int ReviewRates { get; set; }
        public int ReviewRatingcount { get; set; }
        public decimal ReviewRating { get; set; }
        public int? ReviewEditable { get; set; }
        public string Lastip { get; set; }
        public int? Published { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}

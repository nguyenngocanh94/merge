using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartRating
    {
        public int VirtuemartRatingId { get; set; }
        public int VirtuemartProductId { get; set; }
        public int Rates { get; set; }
        public int Ratingcount { get; set; }
        public decimal Rating { get; set; }
        public int? Published { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
    }
}

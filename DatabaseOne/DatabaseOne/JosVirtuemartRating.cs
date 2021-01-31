using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
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

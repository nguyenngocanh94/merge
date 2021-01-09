using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartRatingVote
    {
        public int VirtuemartRatingVoteId { get; set; }
        public int VirtuemartProductId { get; set; }
        public int Vote { get; set; }
        public string Lastip { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
    }
}

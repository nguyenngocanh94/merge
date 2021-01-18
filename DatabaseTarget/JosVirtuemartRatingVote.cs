using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosVirtuemartRatingVote
    {
        public uint VirtuemartRatingVoteId { get; set; }
        public uint VirtuemartProductId { get; set; }
        public int Vote { get; set; }
        public string Lastip { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
    }
}

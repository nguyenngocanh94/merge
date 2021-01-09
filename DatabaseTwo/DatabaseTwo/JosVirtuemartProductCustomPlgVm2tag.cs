using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartProductCustomPlgVm2tag
    {
        public int Id { get; set; }
        public int? VirtuemartProductId { get; set; }
        public int? VirtuemartCustomId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}

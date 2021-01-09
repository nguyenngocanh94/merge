using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartWaitinguser
    {
        public int VirtuemartWaitinguserId { get; set; }
        public int VirtuemartProductId { get; set; }
        public int VirtuemartUserId { get; set; }
        public string NotifyEmail { get; set; }
        public bool Notified { get; set; }
        public DateTime NotifyDate { get; set; }
        public int Ordering { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosVirtuemartProductCustomPlgIstraxxDownloadSimple
    {
        public uint Id { get; set; }
        public uint? VirtuemartOrderItemId { get; set; }
        public string ClientIp { get; set; }
        public bool? Errorcode { get; set; }
        public string Message { get; set; }
        public uint? VirtuemartProductId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosAcymailingStat
    {
        public uint Mailid { get; set; }
        public uint Senthtml { get; set; }
        public uint Senttext { get; set; }
        public uint Senddate { get; set; }
        public uint Openunique { get; set; }
        public uint Opentotal { get; set; }
        public uint Bounceunique { get; set; }
        public uint Fail { get; set; }
        public uint Clicktotal { get; set; }
        public uint Clickunique { get; set; }
        public uint Unsub { get; set; }
        public uint Forward { get; set; }
        public string Bouncedetails { get; set; }
    }
}

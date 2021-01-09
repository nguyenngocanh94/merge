using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosAcymailingStat
    {
        public int Mailid { get; set; }
        public int Senthtml { get; set; }
        public int Senttext { get; set; }
        public int Senddate { get; set; }
        public int Openunique { get; set; }
        public int Opentotal { get; set; }
        public int Bounceunique { get; set; }
        public int Fail { get; set; }
        public int Clicktotal { get; set; }
        public int Clickunique { get; set; }
        public int Unsub { get; set; }
        public int Forward { get; set; }
        public string Bouncedetails { get; set; }
    }
}

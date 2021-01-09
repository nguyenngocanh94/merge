using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosAcymailingHistory
    {
        public int Subid { get; set; }
        public int Date { get; set; }
        public string Ip { get; set; }
        public string Action { get; set; }
        public string Data { get; set; }
        public string Source { get; set; }
        public int? Mailid { get; set; }
    }
}

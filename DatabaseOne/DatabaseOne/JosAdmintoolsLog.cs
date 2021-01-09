using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosAdmintoolsLog
    {
        public ulong Id { get; set; }
        public DateTime Logdate { get; set; }
        public string Ip { get; set; }
        public string Url { get; set; }
        public string Reason { get; set; }
        public string Extradata { get; set; }
    }
}

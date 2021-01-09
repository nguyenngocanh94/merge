using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosAdmintoolsIpautobanhistory
    {
        public ulong Id { get; set; }
        public string Ip { get; set; }
        public string Reason { get; set; }
        public DateTime? Until { get; set; }
    }
}

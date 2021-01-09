using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosAdmintoolsIpblock
    {
        public ulong Id { get; set; }
        public string Ip { get; set; }
        public string Description { get; set; }
    }
}

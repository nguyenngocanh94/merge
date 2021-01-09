using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosAdmintoolsCookie
    {
        public string Series { get; set; }
        public string ClientHash { get; set; }
        public DateTime ValidTo { get; set; }
    }
}

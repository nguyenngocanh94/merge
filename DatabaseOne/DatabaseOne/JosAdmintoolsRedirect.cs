using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosAdmintoolsRedirect
    {
        public ulong Id { get; set; }
        public string Source { get; set; }
        public string Dest { get; set; }
        public long Ordering { get; set; }
        public bool? Published { get; set; }
        public bool? Keepurlparams { get; set; }
    }
}

using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosAdmintoolsProfile
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Configuration { get; set; }
        public string Filters { get; set; }
    }
}

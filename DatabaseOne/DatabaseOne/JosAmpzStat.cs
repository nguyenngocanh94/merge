using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosAmpzStat
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Network { get; set; }
        public string Position { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
    }
}

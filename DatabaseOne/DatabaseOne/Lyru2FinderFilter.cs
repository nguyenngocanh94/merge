using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class Lyru2FinderFilter
    {
        public int FilterId { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public bool? State { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedByAlias { get; set; }
        public DateTime Modified { get; set; }
        public int ModifiedBy { get; set; }
        public int CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public int MapCount { get; set; }
        public string Data { get; set; }
        public string Params { get; set; }
    }
}

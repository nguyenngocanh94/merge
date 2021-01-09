using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class Lyru2ContentitemTagMap
    {
        public string TypeAlias { get; set; }
        public int CoreContentId { get; set; }
        public int ContentItemId { get; set; }
        public int TagId { get; set; }
        public DateTime TagDate { get; set; }
        public int TypeId { get; set; }
    }
}

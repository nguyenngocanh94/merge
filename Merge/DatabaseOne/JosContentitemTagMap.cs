using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosContentitemTagMap
    {
        public string TypeAlias { get; set; }
        public uint CoreContentId { get; set; }
        public int ContentItemId { get; set; }
        public uint TagId { get; set; }
        public DateTime TagDate { get; set; }
        public int TypeId { get; set; }
    }
}

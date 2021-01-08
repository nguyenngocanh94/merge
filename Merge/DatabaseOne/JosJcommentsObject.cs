using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosJcommentsObject
    {
        public uint Id { get; set; }
        public uint ObjectId { get; set; }
        public string ObjectGroup { get; set; }
        public uint CategoryId { get; set; }
        public string Lang { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public byte Access { get; set; }
        public uint Userid { get; set; }
        public byte Expired { get; set; }
        public DateTime Modified { get; set; }
    }
}

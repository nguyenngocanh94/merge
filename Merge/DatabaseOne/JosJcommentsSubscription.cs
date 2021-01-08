using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosJcommentsSubscription
    {
        public uint Id { get; set; }
        public uint ObjectId { get; set; }
        public string ObjectGroup { get; set; }
        public string Lang { get; set; }
        public uint Userid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Hash { get; set; }
        public byte Published { get; set; }
        public string Source { get; set; }
        public uint CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
    }
}

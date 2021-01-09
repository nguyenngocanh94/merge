using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosJcommentsSubscription
    {
        public int Id { get; set; }
        public int ObjectId { get; set; }
        public string ObjectGroup { get; set; }
        public string Lang { get; set; }
        public int Userid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Hash { get; set; }
        public byte Published { get; set; }
        public string Source { get; set; }
        public int CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
    }
}

using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class Lyru2Message
    {
        public int MessageId { get; set; }
        public int UserIdFrom { get; set; }
        public int UserIdTo { get; set; }
        public byte FolderId { get; set; }
        public DateTime DateTime { get; set; }
        public bool State { get; set; }
        public byte Priority { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}

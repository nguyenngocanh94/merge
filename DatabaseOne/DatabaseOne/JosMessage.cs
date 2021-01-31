using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosMessage
    {
        public int MessageId { get; set; }
        public int UserIdFrom { get; set; }
        public int UserIdTo { get; set; }
        public byte FolderId { get; set; }
        public DateTime DateTime { get; set; }
        public int State { get; set; }
        public byte Priority { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}

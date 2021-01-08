using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosUserNote
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public uint Catid { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public sbyte State { get; set; }
        public uint CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public uint CreatedUserId { get; set; }
        public DateTime CreatedTime { get; set; }
        public uint ModifiedUserId { get; set; }
        public DateTime ModifiedTime { get; set; }
        public DateTime ReviewTime { get; set; }
        public DateTime PublishUp { get; set; }
        public DateTime PublishDown { get; set; }
    }
}

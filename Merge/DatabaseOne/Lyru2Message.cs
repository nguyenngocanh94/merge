﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class Lyru2Message
    {
        public uint MessageId { get; set; }
        public uint UserIdFrom { get; set; }
        public uint UserIdTo { get; set; }
        public byte FolderId { get; set; }
        public DateTime DateTime { get; set; }
        public bool State { get; set; }
        public byte Priority { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}

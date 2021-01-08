using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class Lyru2Session
    {
        public string SessionId { get; set; }
        public byte ClientId { get; set; }
        public byte? Guest { get; set; }
        public string Time { get; set; }
        public string Data { get; set; }
        public int? Userid { get; set; }
        public string Username { get; set; }
    }
}

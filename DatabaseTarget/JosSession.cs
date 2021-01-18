using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosSession
    {
        public byte[] SessionId { get; set; }
        public byte? ClientId { get; set; }
        public byte? Guest { get; set; }
        public int Time { get; set; }
        public string Data { get; set; }
        public int? Userid { get; set; }
        public string Username { get; set; }
    }
}

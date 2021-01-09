using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosSession
    {
        public string SessionId { get; set; }
        public byte? ClientId { get; set; }
        public byte? Guest { get; set; }
        public string Time { get; set; }
        public string Data { get; set; }
        public int? Userid { get; set; }
        public string Username { get; set; }
    }
}

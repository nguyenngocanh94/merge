using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosJcommentsVote
    {
        public uint Id { get; set; }
        public uint Commentid { get; set; }
        public uint Userid { get; set; }
        public string Ip { get; set; }
        public DateTime Date { get; set; }
        public bool Value { get; set; }
    }
}

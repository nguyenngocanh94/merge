using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosJcommentsVote
    {
        public int Id { get; set; }
        public int Commentid { get; set; }
        public int Userid { get; set; }
        public string Ip { get; set; }
        public DateTime Date { get; set; }
        public int Value { get; set; }
    }
}

using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosJcommentsBlacklist
    {
        public int Id { get; set; }
        public string Ip { get; set; }
        public int Userid { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Expire { get; set; }
        public string Reason { get; set; }
        public string Notes { get; set; }
        public int CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public string Editor { get; set; }
    }
}

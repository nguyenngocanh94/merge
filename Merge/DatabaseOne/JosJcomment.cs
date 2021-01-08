using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosJcomment
    {
        public uint Id { get; set; }
        public uint Parent { get; set; }
        public uint ThreadId { get; set; }
        public string Path { get; set; }
        public byte Level { get; set; }
        public uint ObjectId { get; set; }
        public string ObjectGroup { get; set; }
        public string ObjectParams { get; set; }
        public string Lang { get; set; }
        public uint Userid { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Homepage { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string Ip { get; set; }
        public DateTime Date { get; set; }
        public short Isgood { get; set; }
        public short Ispoor { get; set; }
        public byte Published { get; set; }
        public byte Deleted { get; set; }
        public byte Subscribe { get; set; }
        public string Source { get; set; }
        public uint SourceId { get; set; }
        public uint CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public string Editor { get; set; }
    }
}

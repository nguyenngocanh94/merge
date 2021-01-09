using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosJcommentsObject
    {
        public int Id { get; set; }
        public int ObjectId { get; set; }
        public string ObjectGroup { get; set; }
        public int CategoryId { get; set; }
        public string Lang { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public byte Access { get; set; }
        public int Userid { get; set; }
        public byte Expired { get; set; }
        public DateTime Modified { get; set; }
    }
}

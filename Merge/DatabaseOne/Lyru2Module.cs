using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class Lyru2Module
    {
        public int Id { get; set; }
        public uint AssetId { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public string Content { get; set; }
        public int Ordering { get; set; }
        public string Position { get; set; }
        public uint CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public DateTime PublishUp { get; set; }
        public DateTime PublishDown { get; set; }
        public bool Published { get; set; }
        public string Module { get; set; }
        public uint Access { get; set; }
        public byte Showtitle { get; set; }
        public string Params { get; set; }
        public sbyte ClientId { get; set; }
        public string Language { get; set; }
    }
}

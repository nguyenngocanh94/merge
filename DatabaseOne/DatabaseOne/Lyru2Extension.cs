using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class Lyru2Extension
    {
        public int ExtensionId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Element { get; set; }
        public string Folder { get; set; }
        public sbyte ClientId { get; set; }
        public sbyte Enabled { get; set; }
        public int Access { get; set; }
        public sbyte Protected { get; set; }
        public string ManifestCache { get; set; }
        public string Params { get; set; }
        public string CustomData { get; set; }
        public string SystemData { get; set; }
        public int CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public int? Ordering { get; set; }
        public int? State { get; set; }
    }
}

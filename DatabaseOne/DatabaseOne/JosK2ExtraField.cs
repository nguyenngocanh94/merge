using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosK2ExtraField
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
        public int Group { get; set; }
        public sbyte Published { get; set; }
        public int Ordering { get; set; }
    }
}

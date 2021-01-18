using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
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

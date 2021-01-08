using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosRsformProperty
    {
        public int PropertyId { get; set; }
        public int ComponentId { get; set; }
        public string PropertyName { get; set; }
        public string PropertyValue { get; set; }
    }
}

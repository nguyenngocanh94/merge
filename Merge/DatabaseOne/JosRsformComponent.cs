using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosRsformComponent
    {
        public int ComponentId { get; set; }
        public int FormId { get; set; }
        public int ComponentTypeId { get; set; }
        public int Order { get; set; }
        public bool? Published { get; set; }
    }
}

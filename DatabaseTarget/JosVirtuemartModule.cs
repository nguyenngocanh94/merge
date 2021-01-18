using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosVirtuemartModule
    {
        public uint ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string ModuleDescription { get; set; }
        public string ModulePerms { get; set; }
        public bool? Published { get; set; }
        public string IsAdmin { get; set; }
        public int Ordering { get; set; }
    }
}

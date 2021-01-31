using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartModule
    {
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string ModuleDescription { get; set; }
        public string ModulePerms { get; set; }
        public int? Published { get; set; }
        public string IsAdmin { get; set; }
        public int Ordering { get; set; }
    }
}

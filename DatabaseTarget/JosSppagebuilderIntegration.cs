using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosSppagebuilderIntegration
    {
        public ulong Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Component { get; set; }
        public string Plugin { get; set; }
        public bool State { get; set; }
    }
}

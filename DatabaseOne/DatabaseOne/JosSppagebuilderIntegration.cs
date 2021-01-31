using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosSppagebuilderIntegration
    {
        public ulong Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Component { get; set; }
        public string Plugin { get; set; }
        public int State { get; set; }
    }
}

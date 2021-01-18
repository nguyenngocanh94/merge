using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosSppagebuilderSection
    {
        public uint Id { get; set; }
        public string Title { get; set; }
        public string Section { get; set; }
        public DateTime Created { get; set; }
        public long CreatedBy { get; set; }
    }
}

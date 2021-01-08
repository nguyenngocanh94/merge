using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosJcommentsVersion
    {
        public string Version { get; set; }
        public string Previous { get; set; }
        public DateTime Installed { get; set; }
        public DateTime Updated { get; set; }
    }
}

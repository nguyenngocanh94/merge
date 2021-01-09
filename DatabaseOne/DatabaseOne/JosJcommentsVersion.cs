using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosJcommentsVersion
    {
        public string Version { get; set; }
        public string Previous { get; set; }
        public DateTime Installed { get; set; }
        public DateTime Updated { get; set; }
    }
}

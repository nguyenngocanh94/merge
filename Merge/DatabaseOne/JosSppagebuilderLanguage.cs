using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosSppagebuilderLanguage
    {
        public uint Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string LangTag { get; set; }
        public string LangKey { get; set; }
        public string Version { get; set; }
        public bool State { get; set; }
    }
}

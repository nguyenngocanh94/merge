using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosSppagebuilderLanguage
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string LangTag { get; set; }
        public string LangKey { get; set; }
        public string Version { get; set; }
        public bool State { get; set; }
    }
}

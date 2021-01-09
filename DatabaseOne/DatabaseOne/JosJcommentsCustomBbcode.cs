using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosJcommentsCustomBbcode
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SimplePattern { get; set; }
        public string SimpleReplacementHtml { get; set; }
        public string SimpleReplacementText { get; set; }
        public string Pattern { get; set; }
        public string ReplacementHtml { get; set; }
        public string ReplacementText { get; set; }
        public string ButtonAcl { get; set; }
        public string ButtonOpenTag { get; set; }
        public string ButtonCloseTag { get; set; }
        public string ButtonTitle { get; set; }
        public string ButtonPrompt { get; set; }
        public string ButtonImage { get; set; }
        public string ButtonCss { get; set; }
        public byte ButtonEnabled { get; set; }
        public int Ordering { get; set; }
        public byte Published { get; set; }
        public int CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
    }
}

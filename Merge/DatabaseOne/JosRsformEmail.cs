using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosRsformEmail
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public string Type { get; set; }
        public string From { get; set; }
        public string Fromname { get; set; }
        public string Replyto { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string Subject { get; set; }
        public bool Mode { get; set; }
        public string Message { get; set; }
    }
}

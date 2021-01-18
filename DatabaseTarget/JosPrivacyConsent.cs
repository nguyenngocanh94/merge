using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosPrivacyConsent
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public int State { get; set; }
        public DateTime Created { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public sbyte Remind { get; set; }
        public string Token { get; set; }
    }
}

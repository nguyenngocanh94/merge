using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosPrivacyRequest
    {
        public uint Id { get; set; }
        public string Email { get; set; }
        public DateTime RequestedAt { get; set; }
        public sbyte Status { get; set; }
        public string RequestType { get; set; }
        public string ConfirmToken { get; set; }
        public DateTime ConfirmTokenCreatedAt { get; set; }
    }
}

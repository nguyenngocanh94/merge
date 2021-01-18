using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosAcymailingAction
    {
        public uint ActionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public uint Frequency { get; set; }
        public uint Nextdate { get; set; }
        public string Server { get; set; }
        public string Port { get; set; }
        public string ConnectionMethod { get; set; }
        public string SecureMethod { get; set; }
        public sbyte SelfSigned { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public uint? Userid { get; set; }
        public string Conditions { get; set; }
        public string Actions { get; set; }
        public string Report { get; set; }
        public sbyte Published { get; set; }
        public ushort? Ordering { get; set; }
        public sbyte DeleteWrongEmails { get; set; }
    }
}

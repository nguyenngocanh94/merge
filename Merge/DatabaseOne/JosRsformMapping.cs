using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosRsformMapping
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public bool Connection { get; set; }
        public string Host { get; set; }
        public string Driver { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }
        public bool Method { get; set; }
        public string Table { get; set; }
        public string Data { get; set; }
        public string Wheredata { get; set; }
        public string Extra { get; set; }
        public string Andor { get; set; }
        public int Ordering { get; set; }
    }
}

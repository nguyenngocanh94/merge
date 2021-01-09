using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosAdmintoolsScan
    {
        public ulong Id { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public DateTime Backupstart { get; set; }
        public DateTime Backupend { get; set; }
        public string Status { get; set; }
        public string Origin { get; set; }
        public string Type { get; set; }
        public long ProfileId { get; set; }
        public string Archivename { get; set; }
        public string AbsolutePath { get; set; }
        public int Multipart { get; set; }
        public string Tag { get; set; }
        public string Backupid { get; set; }
        public sbyte Filesexist { get; set; }
        public string RemoteFilename { get; set; }
        public long TotalSize { get; set; }
    }
}

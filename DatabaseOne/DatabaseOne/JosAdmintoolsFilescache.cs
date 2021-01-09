using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosAdmintoolsFilescache
    {
        public long AdmintoolsFilescacheId { get; set; }
        public string Path { get; set; }
        public int Filedate { get; set; }
        public int Filesize { get; set; }
        public byte[] Data { get; set; }
        public string Checksum { get; set; }
    }
}

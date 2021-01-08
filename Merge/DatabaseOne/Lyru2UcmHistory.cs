using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class Lyru2UcmHistory
    {
        public uint VersionId { get; set; }
        public uint UcmItemId { get; set; }
        public uint UcmTypeId { get; set; }
        public string VersionNote { get; set; }
        public DateTime SaveDate { get; set; }
        public uint EditorUserId { get; set; }
        public uint CharacterCount { get; set; }
        public string Sha1Hash { get; set; }
        public string VersionData { get; set; }
        public sbyte KeepForever { get; set; }
    }
}

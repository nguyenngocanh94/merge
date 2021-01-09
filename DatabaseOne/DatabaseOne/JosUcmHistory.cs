using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosUcmHistory
    {
        public int VersionId { get; set; }
        public int UcmItemId { get; set; }
        public int UcmTypeId { get; set; }
        public string VersionNote { get; set; }
        public DateTime SaveDate { get; set; }
        public int EditorUserId { get; set; }
        public int CharacterCount { get; set; }
        public string Sha1Hash { get; set; }
        public string VersionData { get; set; }
        public sbyte KeepForever { get; set; }
    }
}

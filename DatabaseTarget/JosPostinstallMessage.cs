using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosPostinstallMessage
    {
        public ulong PostinstallMessageId { get; set; }
        public long ExtensionId { get; set; }
        public string TitleKey { get; set; }
        public string DescriptionKey { get; set; }
        public string ActionKey { get; set; }
        public string LanguageExtension { get; set; }
        public sbyte LanguageClientId { get; set; }
        public string Type { get; set; }
        public string ActionFile { get; set; }
        public string Action { get; set; }
        public string ConditionFile { get; set; }
        public string ConditionMethod { get; set; }
        public string VersionIntroduced { get; set; }
        public sbyte Enabled { get; set; }
    }
}

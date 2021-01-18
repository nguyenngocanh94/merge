using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosUpdate
    {
        public int UpdateId { get; set; }
        public int? UpdateSiteId { get; set; }
        public int? ExtensionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Element { get; set; }
        public string Type { get; set; }
        public string Folder { get; set; }
        public sbyte? ClientId { get; set; }
        public string Version { get; set; }
        public string Data { get; set; }
        public string Detailsurl { get; set; }
        public string Infourl { get; set; }
        public string ExtraQuery { get; set; }
    }
}

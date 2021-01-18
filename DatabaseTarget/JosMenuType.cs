using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosMenuType
    {
        public uint Id { get; set; }
        public uint AssetId { get; set; }
        public string Menutype { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ClientId { get; set; }
    }
}

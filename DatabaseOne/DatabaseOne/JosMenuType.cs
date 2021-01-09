using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosMenuType
    {
        public int Id { get; set; }
        public int AssetId { get; set; }
        public string Menutype { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ClientId { get; set; }
    }
}

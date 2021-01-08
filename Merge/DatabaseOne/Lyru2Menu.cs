using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class Lyru2Menu
    {
        public int Id { get; set; }
        public string Menutype { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Note { get; set; }
        public string Path { get; set; }
        public string Link { get; set; }
        public string Type { get; set; }
        public sbyte Published { get; set; }
        public uint ParentId { get; set; }
        public uint Level { get; set; }
        public uint ComponentId { get; set; }
        public uint CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public sbyte BrowserNav { get; set; }
        public uint Access { get; set; }
        public string Img { get; set; }
        public uint TemplateStyleId { get; set; }
        public string Params { get; set; }
        public int Lft { get; set; }
        public int Rgt { get; set; }
        public byte Home { get; set; }
        public string Language { get; set; }
        public sbyte ClientId { get; set; }
    }
}

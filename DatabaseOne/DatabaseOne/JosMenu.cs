using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosMenu
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
        public int ParentId { get; set; }
        public int Level { get; set; }
        public int ComponentId { get; set; }
        public int CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public sbyte BrowserNav { get; set; }
        public int Access { get; set; }
        public string Img { get; set; }
        public int TemplateStyleId { get; set; }
        public string Params { get; set; }
        public int Lft { get; set; }
        public int Rgt { get; set; }
        public byte Home { get; set; }
        public string Language { get; set; }
        public sbyte ClientId { get; set; }
        public int Ordering { get; set; }
    }
}

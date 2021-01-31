using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosRsformComponent
    {
        public int ComponentId { get; set; }
        public int FormId { get; set; }
        public int ComponentTypeId { get; set; }
        public int Order { get; set; }
        public int? Published { get; set; }
    }
}

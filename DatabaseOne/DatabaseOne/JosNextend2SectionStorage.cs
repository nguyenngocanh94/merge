using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosNextend2SectionStorage
    {
        public int Id { get; set; }
        public string Application { get; set; }
        public string Section { get; set; }
        public string Referencekey { get; set; }
        public string Value { get; set; }
        public int System { get; set; }
        public int Editable { get; set; }
    }
}

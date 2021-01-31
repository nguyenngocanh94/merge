using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosRsformDirectoryField
    {
        public int FormId { get; set; }
        public int ComponentId { get; set; }
        public int Viewable { get; set; }
        public int Searchable { get; set; }
        public int Editable { get; set; }
        public int Indetails { get; set; }
        public int Incsv { get; set; }
        public int Ordering { get; set; }
    }
}

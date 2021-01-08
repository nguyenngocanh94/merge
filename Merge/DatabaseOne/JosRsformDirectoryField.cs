using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosRsformDirectoryField
    {
        public int FormId { get; set; }
        public int ComponentId { get; set; }
        public bool Viewable { get; set; }
        public bool Searchable { get; set; }
        public bool Editable { get; set; }
        public bool Indetails { get; set; }
        public bool Incsv { get; set; }
        public int Ordering { get; set; }
    }
}

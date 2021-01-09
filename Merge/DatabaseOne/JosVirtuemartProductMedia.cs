using System;
using System.Collections.Generic;
using Merge.Extensions;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosVirtuemartProductMedia : EntityUtilities
    {
        public int Id { get; set; }
        public int VirtuemartProductId { get; set; }
        public int VirtuemartMediaId { get; set; }
        public int Ordering { get; set; }
    }
}

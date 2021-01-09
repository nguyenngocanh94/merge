using System;
using DatabaseOne.Extensions;


#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartCategoryMedia : EntityUtilities
    {
        public int Id { get; set; }
        public int VirtuemartCategoryId { get; set; }
        public int VirtuemartMediaId { get; set; }
        public int Ordering { get; set; }
    }
}

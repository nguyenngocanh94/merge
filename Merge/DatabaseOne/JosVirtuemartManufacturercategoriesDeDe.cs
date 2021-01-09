using System;
using System.Collections.Generic;
using Merge.Extensions;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosVirtuemartManufacturercategoriesDeDe  : EntityUtilities
    {
        public uint VirtuemartManufacturercategoriesId { get; set; }
        public string MfCategoryName { get; set; }
        public string MfCategoryDesc { get; set; }
        public string Slug { get; set; }
    }
}

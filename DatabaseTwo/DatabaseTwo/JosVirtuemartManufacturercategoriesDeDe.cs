using System;
using System.Collections.Generic;
using DatabaseTwo.Extensions;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartManufacturercategoriesDeDe  : EntityUtilities
    {
        public int VirtuemartManufacturercategoriesId { get; set; }
        public string MfCategoryName { get; set; }
        public string MfCategoryDesc { get; set; }
        public string Slug { get; set; }
    }
}

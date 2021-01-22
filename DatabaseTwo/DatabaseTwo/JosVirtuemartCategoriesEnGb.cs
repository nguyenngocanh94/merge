using System;
using System.Collections.Generic;
using DatabaseTwo.Extensions;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartCategoriesEnGb : EntityUtilities
    {
        public int VirtuemartCategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string Metadesc { get; set; }
        public string Metakey { get; set; }
        public string Customtitle { get; set; }
        public string Slug { get; set; }
    }
}

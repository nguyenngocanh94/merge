using System;
using DatabaseOne.Extensions;
using DatabaseTwo.DatabaseTwo;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartCategoriesFrFr : EntityUtilities , ISlug
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

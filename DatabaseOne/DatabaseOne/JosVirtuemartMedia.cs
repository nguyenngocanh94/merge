using System;
using DatabaseOne.Extensions;


#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartMedia : EntityUtilities
    {
        public int VirtuemartMediaId { get; set; }
        public short VirtuemartVendorId { get; set; }
        public string FileTitle { get; set; }
        public string FileDescription { get; set; }
        public string FileMeta { get; set; }
        public string FileClass { get; set; }
        public string FileMimetype { get; set; }
        public string FileType { get; set; }
        public string FileUrl { get; set; }
        public string FileUrlThumb { get; set; }
        public int FileIsProductImage { get; set; }
        public int FileIsDownloadable { get; set; }
        public int FileIsForSale { get; set; }
        public string FileParams { get; set; }
        public string FileLang { get; set; }
        public int Ordering { get; set; }
        public int Shared { get; set; }
        public int? Published { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}

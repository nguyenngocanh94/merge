using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseTwo
{
    public partial class JosVirtuemartMedia
    {
        public uint VirtuemartMediaId { get; set; }
        public short VirtuemartVendorId { get; set; }
        public string FileTitle { get; set; }
        public string FileDescription { get; set; }
        public string FileMeta { get; set; }
        public string FileClass { get; set; }
        public string FileMimetype { get; set; }
        public string FileType { get; set; }
        public string FileUrl { get; set; }
        public string FileUrlThumb { get; set; }
        public bool FileIsProductImage { get; set; }
        public bool FileIsDownloadable { get; set; }
        public bool FileIsForSale { get; set; }
        public string FileParams { get; set; }
        public string FileLang { get; set; }
        public int Ordering { get; set; }
        public bool Shared { get; set; }
        public bool? Published { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}

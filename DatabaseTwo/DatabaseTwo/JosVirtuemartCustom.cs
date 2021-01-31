using System;
using System.Collections.Generic;
using DatabaseTwo.Extensions;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartCustom : EntityUtilities
    {
        public int VirtuemartCustomId { get; set; }
        public int? ShowTitle { get; set; }
        public int CustomParentId { get; set; }
        public short VirtuemartVendorId { get; set; }
        public int CustomJpluginId { get; set; }
        public string CustomElement { get; set; }
        public int AdminOnly { get; set; }
        public string CustomTitle { get; set; }
        public string CustomTip { get; set; }
        public string CustomValue { get; set; }
        public string CustomDesc { get; set; }
        public string FieldType { get; set; }
        public int IsInput { get; set; }
        public int IsList { get; set; }
        public int IsHidden { get; set; }
        public int IsCartAttribute { get; set; }
        public string LayoutPos { get; set; }
        public string CustomParams { get; set; }
        public int Shared { get; set; }
        public int? Published { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public int Ordering { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}

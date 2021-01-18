using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosVirtuemartCustom
    {
        public uint VirtuemartCustomId { get; set; }
        public bool? ShowTitle { get; set; }
        public string CustomTip { get; set; }
        public string CustomValue { get; set; }
        public string CustomDesc { get; set; }
        public uint CustomParentId { get; set; }
        public uint VirtuemartVendorId { get; set; }
        public int CustomJpluginId { get; set; }
        public string CustomElement { get; set; }
        public bool AdminOnly { get; set; }
        public string CustomTitle { get; set; }
        public string FieldType { get; set; }
        public bool IsInput { get; set; }
        public bool Searchable { get; set; }
        public string LayoutPos { get; set; }
        public bool IsList { get; set; }
        public bool IsHidden { get; set; }
        public bool IsCartAttribute { get; set; }
        public string CustomParams { get; set; }
        public string VirtuemartShoppergroupId { get; set; }
        public bool Shared { get; set; }
        public bool? Published { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public int Ordering { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}

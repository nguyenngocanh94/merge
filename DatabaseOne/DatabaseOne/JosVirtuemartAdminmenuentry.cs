﻿using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartAdminmenuentry
    {
        public byte Id { get; set; }
        public byte ModuleId { get; set; }
        public byte ParentId { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string Depends { get; set; }
        public string IconClass { get; set; }
        public int Ordering { get; set; }
        public int? Published { get; set; }
        public string Tooltip { get; set; }
        public string View { get; set; }
        public string Task { get; set; }
    }
}

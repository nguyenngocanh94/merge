﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseTwo
{
    public partial class JosVirtuemartPaymentmethodShoppergroup
    {
        public uint Id { get; set; }
        public uint VirtuemartPaymentmethodId { get; set; }
        public ushort VirtuemartShoppergroupId { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosVirtuemartProductCustomPlgParamValue
    {
        public int Id { get; set; }
        public int VirtuemartCustomId { get; set; }
        public string Value { get; set; }
        public int Status { get; set; }
        public int Published { get; set; }
        public int Ordering { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosRsformTranslation
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public string LangCode { get; set; }
        public string Reference { get; set; }
        public string ReferenceId { get; set; }
        public string Value { get; set; }
    }
}

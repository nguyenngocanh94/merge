using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosRsformSubmissionValue
    {
        public int SubmissionValueId { get; set; }
        public int FormId { get; set; }
        public int SubmissionId { get; set; }
        public string FieldName { get; set; }
        public string FieldValue { get; set; }
    }
}

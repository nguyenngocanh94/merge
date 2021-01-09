using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
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

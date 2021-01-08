﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosRsformSubmission
    {
        public int SubmissionId { get; set; }
        public int FormId { get; set; }
        public DateTime DateSubmitted { get; set; }
        public string UserIp { get; set; }
        public string Username { get; set; }
        public string UserId { get; set; }
        public string Lang { get; set; }
        public bool Confirmed { get; set; }
    }
}

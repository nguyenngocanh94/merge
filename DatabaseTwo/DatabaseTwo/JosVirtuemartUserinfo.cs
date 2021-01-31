﻿using System;
using System.Collections.Generic;
using DatabaseTwo.Extensions;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartUserinfo : EntityUtilities
    {
        public int Tos { get; set; }
        public string CustomerNote { get; set; }
        public int VirtuemartUserinfoId { get; set; }
        public int VirtuemartUserId { get; set; }
        public string AddressType { get; set; }
        public string AddressTypeName { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int VirtuemartStateId { get; set; }
        public int VirtuemartCountryId { get; set; }
        public string Zip { get; set; }
        public int Agreed { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
    }
}

using System;
using System.Collections.Generic;
using Merge.Extensions;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosVirtuemartOrderUserinfo : EntityUtilities
    {
        public bool Tos { get; set; }
        public string CustomerNote { get; set; }
        public int VirtuemartOrderUserinfoId { get; set; }
        public int VirtuemartOrderId { get; set; }
        public int VirtuemartUserId { get; set; }
        public string AddressType { get; set; }
        public string AddressTypeName { get; set; }
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
        public ushort VirtuemartStateId { get; set; }
        public ushort VirtuemartCountryId { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }
        public bool Agreed { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
        public string CeAdress1 { get; set; }
        public string CeAdress4 { get; set; }
        public string CeDoorCode1 { get; set; }
        public string CeDoorCode2 { get; set; }
        public string CeEntryPhone { get; set; }
    }
}

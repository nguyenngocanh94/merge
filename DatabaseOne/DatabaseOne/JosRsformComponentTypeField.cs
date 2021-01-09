using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosRsformComponentTypeField
    {
        public int ComponentTypeId { get; set; }
        public string FieldName { get; set; }
        public string FieldType { get; set; }
        public string FieldValues { get; set; }
        public string Properties { get; set; }
        public int Ordering { get; set; }
    }
}

using System.Reflection;

namespace Merge.Extensions
{
    public class EntityUtilities
    {
        public int
            this[string propertyName]
        {
            get
            {
                PropertyInfo property = GetType().GetProperty(propertyName);
                return (int) property.GetValue(this, null);
            }
            set
            {
                PropertyInfo property = GetType().GetProperty(propertyName);
                property.SetValue(this,value, null);
            }
        }
    }
}
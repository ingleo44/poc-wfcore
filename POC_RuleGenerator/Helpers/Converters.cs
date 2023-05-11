using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace POC_RuleGenerator.Helpers
{
    public static class Converters
    {
        public static Object TryConvertTo(object input, PropertyInfo property)
        {
            Object result = null;
            try
            {
                result = Convert.ChangeType(input, property.GetType());
            }
            catch
            {
            }

            return result;
        }
    }
}

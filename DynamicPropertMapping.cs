using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assisgnment_22
{
    public class DynamicPropertMapping
    {
        public static void MapProperty(Source source, Destination destination)
        {
            Type sourceType = source.GetType();
            Type destType = destination.GetType();
            PropertyInfo[] sourceProperties = sourceType.GetProperties();
            PropertyInfo[] destProperties = destType.GetProperties();
            foreach (var sourceProp in sourceProperties)
            {
                PropertyInfo destinationProp = Array.Find(destProperties, prop => prop.Name == sourceProp.Name);
                if (destinationProp != null && destinationProp.PropertyType == sourceProp.PropertyType)
                {
                    destinationProp.SetValue(destination, sourceProp.GetValue(source));
                }

            }
        }
    }
}

using PETUtility.Data.Fundamentals.Localizations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PETUtility.Data.Fundamentals
{
    public static class Extension
    {
        public static string GetDescription(this Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());

            DescriptionAttribute attribute
                    = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute))
                        as DescriptionAttribute;

            return attribute == null ? value.ToString() : attribute.Description;
        }

        public static T GetValueFromDescription<T>(string description)
        {
            var type = typeof(T);

            if (!type.IsEnum) throw new InvalidOperationException();

            foreach (var field in type.GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(field,
                    typeof(DescriptionAttribute)) as DescriptionAttribute;

                if (attribute != null)
                {
                    if (string.Equals(attribute.Description, description, StringComparison.OrdinalIgnoreCase))
                        return (T)field.GetValue(null);
                }
            }

            throw new ArgumentException(Localization.Global.Error.EnumNotFound, "description");
        }
    }
}

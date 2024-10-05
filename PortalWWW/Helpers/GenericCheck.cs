using DatabaseAPI.Models.Abstract;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection;

namespace PortalWWW.Helpers
{
    public static class GenericCheck
    {
        public static IHtmlContent DisplayName(this IHtmlHelper html, PropertyInfo property)
        {
            var metadataForProperties = html.MetadataProvider.GetMetadataForProperties(property.DeclaringType);
            var metadata = metadataForProperties.FirstOrDefault(prop => prop.Name == property.Name);
            return new HtmlString(metadata.DisplayName ?? property.Name);
        }

        public static IHtmlContent DisplayValue(this IHtmlHelper html, PropertyInfo property, object model)
        {
            var value = property.GetValue(model, null);
            return new HtmlString(value?.ToString() ?? string.Empty);
        }

        public static bool IsGenericCollection(Type type)
        {
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(ICollection<>))
            {
                return true;
            }

            // Additionally, check if any base type implements ICollection<>
            foreach (Type iface in type.GetInterfaces())
            {
                if (iface.IsGenericType && iface.GetGenericTypeDefinition() == typeof(ICollection<>))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool ShouldShowPropertyOnCreate(String name)
        {
            // Generic Fields
            if (name.Equals("CreatedAt") || name.Equals("ModifiedAt") || name.Equals("Id")) return false;
            // Coupon - Coupon Number
            if (name.Equals("CouponNumber")) return false;
            return true;
        }


        public static string TextTypeBasedOnPropertyType(Type type)
        {
            switch (type)
            {
                case Type t when t == typeof(bool):
                    return "type = checkbox value=true @(propValue as bool? == true ? checked : unchecked)";
                case Type t when t == typeof(bool?):
                    return "type = checkbox value=true @(propValue as bool? == true ? checked : unchecked)";
                case Type t when t == typeof(DateTime):
                    return "type = datetime-local";
                case Type t when t == typeof(DateTime?):
                    return "type = datetime-local";
                default: return "type = text";
            }
        }

        public static bool IsId(string name)
        {
            return name.ToLower().Contains("id");
        }

        public static bool IsTypeOfBaseDatatable(Type type)
        {
            return type.IsSubclassOf(typeof(BaseDatatable));
        }

        public static string GetNameFromPropertyOfObject(PropertyInfo propertyInfo, object item)
        {
            return ((DictionaryTable) propertyInfo.GetValue(item))?.Name;
        }
    }
}

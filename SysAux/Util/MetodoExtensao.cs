using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SysAux.Response;

namespace SysGestao_BE.Auxx
{
    public static class MetodoExtensao
    {

 
        public static string SomenteNumeros(this string value)
        {
            return string.Join("", System.Text.RegularExpressions.Regex.Split(value, @"[^\d]"));
        }

        public static string SomenteLetras(this string value)
        {
            return string.Join("", System.Text.RegularExpressions.Regex.Split(value, @"[^a-zA-Z]+$"));
        }


        public static string GetEnumDescriptionExtension(this Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (attributes != null && attributes.Any())
            {
                return attributes.First().Description;
            }

            return value.ToString();
        }

        public static List<string> GetValuesEnum(this Type tipo)
        {
            var valores = Enum.GetValues(tipo);

            List<string> result;

            if (valores.Length > 0)
            {
                result = new List<string>();
                foreach (Enum x in valores)
                {
                    result.Add(x.GetEnumDescriptionExtension());
                }
                return result;
            }
            return null;
        }

    }
}

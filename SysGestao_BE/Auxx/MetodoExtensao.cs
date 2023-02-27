using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SysAux.Response;
using SysGestao_BE.Produto;
namespace SysGestao_BE.Auxx
{
    public static class MetodoExtensao
    {

        public static T GetValueFromDescription<T>(this string description) where T : Enum
        {
            foreach (var field in typeof(T).GetFields())
            {
                if (Attribute.GetCustomAttribute(field,
                typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
                {
                    if (attribute.Description == description)
                        return (T)field.GetValue(null);
                }
                else
                {
                    if (field.Name == description)
                        return (T)field.GetValue(null);
                }
            }

            throw new ArgumentException("Not found.", nameof(description));
            // Or return default(T);
        }
        public static string QuebraLinha(this string value, int tamanho)
        {
            string aux = "";
            int tamanhoTotal = value.Length;
            if (tamanhoTotal < tamanho)
                return value;

            aux = value.Substring(0, tamanho) + "\n";
            if (tamanho * 2 <= tamanhoTotal)
                aux += value.Substring(tamanho, tamanho );
            else
                aux += value.Substring(tamanho);

            return aux;
        }


        public static string GetEnumDescription(this Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (attributes != null && attributes.Any())
            {
                return attributes.First().Description;
            }

            return value.ToString();
        }

        public static List<string> GetValues(this Type tipo)
        {
            var valores = Enum.GetValues(tipo);

            List<string> result;

            if (valores.Length > 0)
            {
                result = new List<string>();
                foreach (Enum x in valores)
                {
                    result.Add(x.GetEnumDescription());
                }
                return result;
            }
            return null;
        }

    }
}

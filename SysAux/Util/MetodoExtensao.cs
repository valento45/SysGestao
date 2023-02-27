using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Packaging;
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

        public static string FormataCPF(this string value)
        {
            return Convert.ToUInt64(value).ToString(@"000\.000\.000\-00");
        }

        public static string FormataCNPJ(this string value)
        {
            return Convert.ToUInt64(value).ToString(@"00\.000\.000\/0000\-00");
        }


        public static bool IsCnpj(this string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }

    }
}

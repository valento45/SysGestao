using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysAux.Response;
using SysGestao_BE.Produto;
namespace SysGestao_BE.Auxx
{
    public static class MetodoExtensao
    {
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
    }
}

using SysAux.BarCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao_BE.Produto
{
    //Estrutura que modela um único individuo
    public class EtiquetaPDF
    {
        public String sku;
        public String codigoBarra64;
        public string CodigoBarrasText { get; set; }
        public string Variacao { get; set; }

        public EtiquetaPDF(String _sku, String _codigoBarra64, string codigoText, string variacao)
        {
            sku = _sku;
            codigoBarra64 = _codigoBarra64;
            CodigoBarrasText = codigoText;
            Variacao = variacao;
        }
        public override string ToString()
        {
            return $"{sku}\n{CodigoBarras.ConvertBase64ToImage(codigoBarra64)}";
        }
    }
}

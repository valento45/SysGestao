using SysAux.Response;
using SysGestao_BE.Impressao.Interrfaces;
using SysGestao_BE.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao_BE.Impressao
{
    public class PrintObjeto : IPrintObjeto
    {
        public List<EtiquetaPDF> EtiquetasPrint { get ; set ; }
        public PrintObjeto( List<EtiquetaPDF> produtos)
        {
            EtiquetasPrint = produtos;
        }

    }
}

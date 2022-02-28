using SysAux.Response;
using SysGestao_BE.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao_BE.Impressao.Interrfaces
{
    public interface IPrintObjeto
    {
        List<PDF> EtiquetasPrint { get; set; }
    }
}

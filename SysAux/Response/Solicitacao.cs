using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAux.Response
{
    public class Solicitacao
    {
        public string NomeDestinatario { get; set; }
        public List<ProdutoResponse> ProdutosLista { get; set; }   


    }
}

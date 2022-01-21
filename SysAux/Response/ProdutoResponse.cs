using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAux.Response
{
    public class ProdutoResponse
    {
        public int Id { get; set; }
        public string CodigoSKU { get; set; }
        public string Descricao { get; set; }
        public string Variacao { get; set; }
        public int Quantidade { get; set; }
    }
}

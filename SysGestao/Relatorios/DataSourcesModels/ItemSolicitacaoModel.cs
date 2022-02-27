using SysAux.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao.Relatorios.DataSourcesModels
{
    public class ItemSolicitacaoModel
    {
        public int IdItem { get; set; }
        public int IdSolicitacao { get; set; }
        public int IdProduto { get; set; }
        public string CodigoSKU { get; set; }
        public string Variacao { get; set; }
        public int Quantidade { get; set; }

    }
}

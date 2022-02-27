using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao.Relatorios.DataSourcesModels
{
    public class SolicitacaoModel
    {
        public int IdSolicitacao { get; set; }
        public string NomeDestinatario { get; set; }
        public string Status { get; set; }
        public DateTime DataSolicitacao { get; set; }
    }
}

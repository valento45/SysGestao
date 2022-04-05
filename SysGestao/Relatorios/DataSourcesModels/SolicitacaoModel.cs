using SysAux.ObjetosDestinatario;
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
        public Destinatario Destinatario { get; set; }
        public List<ItemSolicitacaoModel> Itens { get; set; } = new List<ItemSolicitacaoModel>();
        public string Status { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public string PeriodoText { get; set; }

        public string GetNomeDestinatario()
        {
            return Destinatario?.Nome;
        }

    }
}

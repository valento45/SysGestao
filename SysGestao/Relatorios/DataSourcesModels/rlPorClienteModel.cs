using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao.Relatorios.DataSourcesModels
{
    public class rlPorClienteModel
    {
        public string PeriodoText { get; set; }
        public List<PreSolicitacaoModel> Solicitacoes { get; set; }

    }
}

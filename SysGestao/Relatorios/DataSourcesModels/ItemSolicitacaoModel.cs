using SysAux.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao.Relatorios.DataSourcesModels
{
    public class ItemSolicitacaoModel
    {
        public int IdItem { get; set; }
        public int IdProduto { get; set; }
        public string CodigoSKU { get; set; }
        public string Variacao { get; set; }
        public int Quantidade { get; set; }
        public string PeriodoText { get; set; }
        public ItemSolicitacaoModel(DataRow row)
        {
            CodigoSKU = row["codigo_sku"].ToString();
            Variacao = row["variacao"].ToString();
            Quantidade = row["quantidade"]?.ToString() != string.Empty ? Convert.ToInt32(row["quantidade"].ToString()) : int.MinValue;
        }
    }
}
